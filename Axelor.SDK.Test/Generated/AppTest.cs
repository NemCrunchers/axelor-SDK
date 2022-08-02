using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Base.Db
{
    [TestClass]
    public class AppTest: TestModel
    {
        public AppTest(): base(typeof(Axelor.Apps.Base.Db.App)){}
    }
}
