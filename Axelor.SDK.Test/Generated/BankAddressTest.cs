using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Base.Db
{
    [Ignore]
    [TestClass]
    public class BankAddressTest: TestModel
    {
        public BankAddressTest(): base(typeof(Axelor.Apps.Base.Db.BankAddress)){}
    }
}
