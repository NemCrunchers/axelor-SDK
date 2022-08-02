using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Base.Db
{
    [TestClass]
    public class AppBaseTest: TestModel
    {
        public AppBaseTest(): base(typeof(Axelor.Apps.Base.Db.AppBase)){}
    }
}
