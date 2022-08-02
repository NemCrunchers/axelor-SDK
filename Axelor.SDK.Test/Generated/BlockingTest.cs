using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Base.Db
{
    [TestClass]
    public class BlockingTest: TestModel
    {
        public BlockingTest(): base(typeof(Axelor.Apps.Base.Db.Blocking)){}
    }
}
