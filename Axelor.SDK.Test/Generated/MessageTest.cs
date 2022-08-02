using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Message.Db
{
    [TestClass]
    public class MessageTest: TestModel
    {
        public MessageTest(): base(typeof(Axelor.Apps.Message.Db.Message)){}
    }
}
