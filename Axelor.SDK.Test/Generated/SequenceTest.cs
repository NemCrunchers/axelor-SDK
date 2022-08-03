using Axelor.SDK.Test;

namespace Axelor.SDK.Test.Apps.Base.Db
{
    [Ignore]
    [TestClass]
    public class SequenceTest: TestModel
    {
        public SequenceTest(): base(typeof(Axelor.Apps.Base.Db.Sequence)){}
    }
}
