using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Axelor.SDK.Exceptions;
using Axelor.SDK.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Axelor.SDK
{
    public class AxelorClient
    {
        private readonly HttpClient httpClient;
        private AuthCookie cookie;

        public AxelorClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ModelMetadata> GetModelMetadataAsync(string modelName)
        {
            HttpResponseMessage res = await this.httpClient.SendAsync(createRequest(HttpMethod.Get, $"/ws/meta/fields/{modelName}"));
            if (res.IsSuccessStatusCode)
            {
                string rawContent = await res.Content.ReadAsStringAsync();
                if(modelName == "com.axelor.apps.account.db.AccountChart")
                {
                    Console.WriteLine("for debugging");
                }
                return JsonConvert.DeserializeObject<ModelMetadata>(rawContent);
            }
            throw new AxelorRequestException();
        }
        public async Task<List<ModelMetadata>> GetModelMetadataAsync()
        {
            
            ServiceMetadata metadata = await GetServiceMetadataAsync();
            IEnumerable<Task<ModelMetadata>> modelTasks = metadata.data.Select(model => GetModelMetadataAsync(model));
            Task.WaitAll(modelTasks.ToArray());
            return modelTasks.Select(t => t.Result).ToList();
        }
        public async Task<ServiceMetadata> GetServiceMetadataAsync()
        {
            HttpResponseMessage res = await this.httpClient.SendAsync(createRequest(HttpMethod.Get, $"/ws/meta/models"));
            if (res.IsSuccessStatusCode)
            {
                string rawContent = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ServiceMetadata>(rawContent);
            }
            throw new AxelorRequestException();
        }
        public async Task<IEnumerable<TObject>> List<TObject>(int offset = 0, int limit = 10) where TObject : AxelorModel
        {
            string modelName = AxelorModelHelper.VerifyTypeAndGetModelName(typeof(TObject));
            HttpResponseMessage res = await this.httpClient.SendAsync(createRequest(HttpMethod.Get, $"/ws/rest/{modelName}?offset={offset}&limit={limit}"));
            if (res.IsSuccessStatusCode)
            {
                string rawContent = await res.Content.ReadAsStringAsync();
                ListModelResponse listResponse = JsonConvert.DeserializeObject<ListModelResponse>(rawContent);
                if(listResponse.data == null)
                {
                    listResponse.data = new List<JObject>();
                }
                return listResponse.data.Select(t => AxelorModelHelper.Cast<TObject>(t));
            }
            throw new AxelorRequestException();
        }
        public async Task<TObject> Get<TObject>(long id) where TObject : AxelorModel
        {
            string modelName = AxelorModelHelper.VerifyTypeAndGetModelName(typeof(TObject));
            HttpResponseMessage res = await this.httpClient.SendAsync(createRequest(HttpMethod.Get, $"/ws/rest/{modelName}/{id}"));
            if (res.IsSuccessStatusCode)
            {
                string rawContent = await res.Content.ReadAsStringAsync();
                ListModelResponse listResponse = JsonConvert.DeserializeObject<ListModelResponse>(rawContent);
                if (listResponse.data == null || listResponse.data.Count == 0)
                {
                    throw new AxelorRecordNotFoundException(typeof(TObject), id);
                }
                return AxelorModelHelper.Cast<TObject>(listResponse.data.FirstOrDefault());
            }
            throw new AxelorRequestException();
        }
        public async Task<TObject> Create<TObject>(TObject ObjectToCreate) where TObject : AxelorModel
        {
            string modelName = AxelorModelHelper.VerifyTypeAndGetModelName(typeof(TObject));
            CreateModelRequest request = new CreateModelRequest()
            {
                data = ObjectToCreate as AxelorModel
            };
            string contentString = JsonConvert.SerializeObject(request, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore,  });
            HttpResponseMessage res = await this.httpClient.SendAsync(createRequest(HttpMethod.Put, $"/ws/rest/{modelName}", new StringContent(contentString, Encoding.UTF8, "application/json")));
            if (res.IsSuccessStatusCode)
            {
                string rawContent = await res.Content.ReadAsStringAsync();

                AxelorModelHelper.CheckResponseForErrors(rawContent);
                ListModelResponse response = JsonConvert.DeserializeObject<ListModelResponse>(rawContent);
                
                return JsonConvert.DeserializeObject<TObject>(JsonConvert.SerializeObject(response.data.FirstOrDefault()));
            }
            throw new AxelorRequestException();
        }
        public async Task<TObject> Update<TObject>(TObject ObjectToUpdate) where TObject : AxelorModel
        {
            string modelName = AxelorModelHelper.VerifyTypeAndGetModelName(typeof(TObject));

            long? id = (long?)AxelorModelHelper.GetField(ObjectToUpdate, "Id");
            if (id == null)
            {
                throw new NoIdFieldSetOnAxelorModel(typeof(TObject));
            }

            CreateModelRequest request = new CreateModelRequest()
            {
                data = ObjectToUpdate as AxelorModel
            };
            string contentString = JsonConvert.SerializeObject(request, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore, });
            HttpResponseMessage res = await this.httpClient.SendAsync(createRequest(HttpMethod.Post, $"/ws/rest/{modelName}/{id}", new StringContent(contentString, Encoding.UTF8, "application/json")));
            if (res.IsSuccessStatusCode)
            {
                string rawContent = await res.Content.ReadAsStringAsync();

                AxelorModelHelper.CheckResponseForErrors(rawContent);
                ListModelResponse response = JsonConvert.DeserializeObject<ListModelResponse>(rawContent);

                return JsonConvert.DeserializeObject<TObject>(JsonConvert.SerializeObject(response.data.FirstOrDefault()));
            }
            throw new AxelorRequestException();
        }
        public async Task Delete<TObject>(TObject ObjectToDelete) where TObject : AxelorModel
        {
            string modelName = AxelorModelHelper.VerifyTypeAndGetModelName(typeof(TObject));

            long? id = (long?)AxelorModelHelper.GetField(ObjectToDelete, "Id");
            if (id == null)
            {
                throw new NoIdFieldSetOnAxelorModel(typeof(TObject));
            }
            
            HttpResponseMessage res = await this.httpClient.SendAsync(createRequest(HttpMethod.Delete, $"/ws/rest/{modelName}/{id}"));
            if (res.IsSuccessStatusCode)
            {
                string rawContent = await res.Content.ReadAsStringAsync();

                AxelorModelHelper.CheckResponseForErrors(rawContent);

                return;
            }
            throw new AxelorRequestException();
        }


        public async Task AuthorizeUser(string username, string password)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{httpClient.BaseAddress}login.jsp"),
                Content = new StringContent("{\n  \"username\": \""+username+"\",\n  \"password\" : \""+password+"\"\n}")
                {
                    Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                        }
                }
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);
            
            if (response.IsSuccessStatusCode)
            {
                WriteCookies(response);
            }
        }

        public bool isAuthenticated()
        {
            return this.cookie != null && this.cookie.Expires > DateTime.UtcNow;
        }
        private void WriteCookies(HttpResponseMessage message)
        {
            message.Headers.TryGetValues("Set-Cookie", out IEnumerable<string> cookiesRaw);
            foreach (string cookie in cookiesRaw)
            {
                if (cookie.StartsWith("JSESSIONID"))
                {
                    this.cookie = new AuthCookie()
                    {
                        JSessionId = cookie.Split(";")[0].Split("=")[1],
                        Expires = DateTime.UtcNow.AddMinutes(30)
                    };
                }
            }
        }
        private HttpRequestMessage createRequest(HttpMethod method, string path, HttpContent body = null, bool json = true)
        {
            HttpRequestMessage req = new HttpRequestMessage(method, $"{path}");
            req.Headers.Add("cookie", $"JSESSIONID={this.cookie.JSessionId}");
            if (json)
            {
                req.Headers.Add("Accept", "application/json");
            }
            if (body != null)
            {
                req.Content = body;
            }
            return req;
        }
    }
}
