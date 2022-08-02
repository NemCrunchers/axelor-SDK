using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Axelor.SDK.Exceptions;
using AxelorCSharp.Models;
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
        public async Task<List<TObject>> List<TObject>(int offset = 0, int limit = 10)
        {
            string modelName = AxelorModelHelper.verifyTypeAndGetModelName(typeof(TObject));
            //HttpResponseMessage res = await this.httpClient.SendAsync(createRequest(HttpMethod.Get, $"/ws/meta/models"));
            //if (res.IsSuccessStatusCode)
            //{
            //    string rawContent = await res.Content.ReadAsStringAsync();
            //    return JsonConvert.DeserializeObject<ServiceMetadata>(rawContent);
            //}
            throw new AxelorRequestException();
        }


        public async Task AuthorizeUser(string username, string password)
        {
            JObject body = JObject.Parse($"{{'username': '{username}', 'password': '{password}'  }}");
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("/login.jsp", body);
            
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
        private HttpRequestMessage createRequest(HttpMethod method, string path, bool json = true)
        {
            HttpRequestMessage req = new HttpRequestMessage(method, $"{path}");
            req.Headers.Add("cookie", $"JSESSIONID=1D7D1A1389F0C6EC5AF69432203D85E8");
            if(json)
            {
                req.Headers.Add("Accept", "application/json");
            }
            return req;
        }
    }
}
