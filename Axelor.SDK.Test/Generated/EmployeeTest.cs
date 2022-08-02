using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Hr.Db
{
    [TestClass]
    public class EmployeeTest: TestModel
    {
        public EmployeeTest(): base(typeof(Axelor.Apps.Hr.Db.Employee)){}
    }
}
