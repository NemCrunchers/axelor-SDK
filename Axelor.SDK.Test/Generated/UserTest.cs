using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Auth.Db
{
    [TestClass]
    public class UserTest: TestModel
    {
        public UserTest(): base(typeof(Axelor.Auth.Db.User)){}
    }
}
