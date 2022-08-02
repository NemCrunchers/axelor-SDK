using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Account.Db
{
    [TestClass]
    public class AccountTest: TestModel
    {
        public AccountTest(): base(typeof(Axelor.Apps.Account.Db.Account)){}
    }
}
