using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Production.Db
{
    [TestClass]
    public class ProductionOrderTest: TestModel
    {
        public ProductionOrderTest(): base(typeof(Axelor.Apps.Production.Db.ProductionOrder)){}
    }
}
