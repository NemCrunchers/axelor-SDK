using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Account.Db
{
    [Ignore]
    [TestClass]
    public class InvoicePaymentTest: TestModel
    {
        public InvoicePaymentTest(): base(typeof(Axelor.Apps.Account.Db.InvoicePayment)){}
    }
}
