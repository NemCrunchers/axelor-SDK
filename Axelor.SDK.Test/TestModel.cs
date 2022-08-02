using Polly;
using Polly.Retry;
using System.Collections;
using System.Reflection;

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
            httpClient.BaseAddress = new Uri("https://7ebb376912.axelor.nemcrunchers.dev");
            _AxelorClient = new AxelorClient(httpClient);
        }

        [ClassInitialize]
        public async Task TestFixtureSetupAsync(TestContext context)
        {
            await this._AxelorClient.AuthorizeUser("admin", "admin");
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
    }
}