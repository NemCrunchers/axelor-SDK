using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Production.Db
{
    [Ignore]
    [TestClass]
    public class ManufOrderTest: TestModel
    {
        public ManufOrderTest(): base(typeof(Axelor.Apps.Production.Db.ManufOrder)){}
    }
}
