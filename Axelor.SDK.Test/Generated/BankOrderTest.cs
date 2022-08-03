using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Bankpayment.Db
{
    [Ignore]
    [TestClass]
    public class BankOrderTest: TestModel
    {
        public BankOrderTest(): base(typeof(Axelor.Apps.Bankpayment.Db.BankOrder)){}
    }
}
