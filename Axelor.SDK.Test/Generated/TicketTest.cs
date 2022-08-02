using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Helpdesk.Db
{
    [TestClass]
    public class TicketTest: TestModel
    {
        public TicketTest(): base(typeof(Axelor.Apps.Helpdesk.Db.Ticket)){}
    }
}
