using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Account.Db
{
    [TestClass]
    public class InvoiceTest: TestModel
    {
        public InvoiceTest(): base(typeof(Axelor.Apps.Account.Db.Invoice)){}
    }
}
