using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Mail.Db
{
    [TestClass]
    public class MailMessageTest: TestModel
    {
        public MailMessageTest(): base(typeof(Axelor.Mail.Db.MailMessage)){}
    }
}
