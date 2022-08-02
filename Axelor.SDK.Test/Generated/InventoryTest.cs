using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Stock.Db
{
    [TestClass]
    public class InventoryTest: TestModel
    {
        public InventoryTest(): base(typeof(Axelor.Apps.Stock.Db.Inventory)){}
    }
}
