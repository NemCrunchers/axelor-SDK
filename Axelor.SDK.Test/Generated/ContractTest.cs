using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Contract.Db
{
    [Ignore]
    [TestClass]
    public class ContractTest: TestModel
    {
        public ContractTest(): base(typeof(Axelor.Apps.Contract.Db.Contract)){}
    }
}
