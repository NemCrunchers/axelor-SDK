using Axelor.Apps.Account.Db;
using Newtonsoft.Json;
using Polly;
using Polly.Retry;
using System.Collections;
using System.Reflection;
using System.Threading.Tasks;

namespace Axelor.SDK.Test
{
    public class TestModel
    {
        private string ModelName { get; set; }
        private Type ModelType { get; set; }
        private AxelorClient _AxelorClient { get; set; }


        private RetryPolicy retryPolicy = Policy.Handle<System.Exception>()
            .WaitAndRetry(retryCount: 3, sleepDurationProvider: _ => TimeSpan.FromSeconds(3));

        public TestModel(Type type)
        {
            ModelType = type;
            this.ModelName = AxelorModelHelper.VerifyTypeAndGetModelName(ModelType);
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Environment.GetEnvironmentVariable("AxelorBaseUrl") ?? "https://demo.axelor.com");
            _AxelorClient = new AxelorClient(httpClient);
        }

        [TestInitialize]
        public async Task TestFixtureSetupAsync()
        {
            if (!this._AxelorClient.isAuthenticated())
            {
                await this._AxelorClient.AuthorizeUser(Environment.GetEnvironmentVariable("AxelorUser") ?? "admin", Environment.GetEnvironmentVariable("AxelorPassword") ?? "admin");
            }
        }
        [TestMethod]
        public async Task ListModel()
        {
            await retryPolicy.Execute(async () =>
            {
                MethodInfo method = typeof(AxelorClient).GetMethod("List");

                method = method.MakeGenericMethod(ModelType);
                Task returnTask = (Task)method.Invoke(_AxelorClient, new object[2] { 0, 10 });
                await returnTask;
            });
        }
        [TestMethod]
        public async Task GetModel()
        {
            await retryPolicy.Execute(async () =>
            {
                MethodInfo method = typeof(AxelorClient).GetMethod("Create").MakeGenericMethod(ModelType);
                MethodInfo fillObject = typeof(AxelorModelHelper).GetMethod("FillRequiredFields").MakeGenericMethod(ModelType);

                object filledObject = fillObject.Invoke(null, new object[1] { Activator.CreateInstance(ModelType)});

                object rawReturn = (method.Invoke(_AxelorClient, new object[1] { filledObject }));
                long id = (long)AxelorModelHelper.GetField(await AxelorModelHelper.MethodResultAsync(rawReturn), "Id");
                
                method = typeof(AxelorClient).GetMethod("Get").MakeGenericMethod(ModelType);
                Task returnTask2 = (Task)method.Invoke(_AxelorClient, new object[1] { id });
                await returnTask2;
            });
        }
        [TestMethod]
        public async Task CreateModel()
        {
            await retryPolicy.Execute(async () =>
            {
                MethodInfo method = typeof(AxelorClient).GetMethod("Create").MakeGenericMethod(ModelType);
                MethodInfo fillObject = typeof(AxelorModelHelper).GetMethod("FillRequiredFields").MakeGenericMethod(ModelType);

                object filledObject = fillObject.Invoke(null, new object[1] { Activator.CreateInstance(ModelType) });

                Task returnTask = (Task)method.Invoke(_AxelorClient, new object[1] { filledObject });
                await returnTask;
            });
        }
        [TestMethod]
        public async Task UpdateModel()
        {
            await retryPolicy.Execute(async () =>
            {
                MethodInfo method = typeof(AxelorClient).GetMethod("Create").MakeGenericMethod(ModelType);
                MethodInfo fillObject = typeof(AxelorModelHelper).GetMethod("FillRequiredFields").MakeGenericMethod(ModelType);

                object filledObject = fillObject.Invoke(null, new object[1] { Activator.CreateInstance(ModelType) });

                object rawReturn = (method.Invoke(_AxelorClient, new object[1] { filledObject }));
                long id = (long)AxelorModelHelper.GetField(await AxelorModelHelper.MethodResultAsync(rawReturn), "Id");

                method = typeof(AxelorClient).GetMethod("Get").MakeGenericMethod(ModelType);
                rawReturn = method.Invoke(_AxelorClient, new object[1] { id });
                object objectReturn = await AxelorModelHelper.MethodResultAsync(rawReturn);

                filledObject = fillObject.Invoke(null, new object[1] { objectReturn });

                method = typeof(AxelorClient).GetMethod("Update").MakeGenericMethod(ModelType);
                Task returnTask2 = (Task)method.Invoke(_AxelorClient, new object[1] { filledObject });
                await returnTask2;
            });
        }
        [TestMethod]
        public async Task DeleteModel()
        {
            await retryPolicy.Execute(async () =>
            {
                MethodInfo method = typeof(AxelorClient).GetMethod("Create").MakeGenericMethod(ModelType);
                MethodInfo fillObject = typeof(AxelorModelHelper).GetMethod("FillRequiredFields").MakeGenericMethod(ModelType);

                object filledObject = fillObject.Invoke(null, new object[1] { Activator.CreateInstance(ModelType) });

                object rawReturn = (method.Invoke(_AxelorClient, new object[1] { filledObject }));
                long id = (long)AxelorModelHelper.GetField(await AxelorModelHelper.MethodResultAsync(rawReturn), "Id");

                method = typeof(AxelorClient).GetMethod("Get").MakeGenericMethod(ModelType);
                rawReturn = method.Invoke(_AxelorClient, new object[1] { id });
                object objectReturn = await AxelorModelHelper.MethodResultAsync(rawReturn);

                method = typeof(AxelorClient).GetMethod("Delete").MakeGenericMethod(ModelType);
                Task returnTask2 = (Task)method.Invoke(_AxelorClient, new object[1] { objectReturn });
                await returnTask2;
            });
        }
    }
}