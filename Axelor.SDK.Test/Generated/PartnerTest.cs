using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Base.Db
{
    [Ignore]
    [TestClass]
    public class PartnerTest: TestModel
    {
        public PartnerTest(): base(typeof(Axelor.Apps.Base.Db.Partner)){}
    }
}
