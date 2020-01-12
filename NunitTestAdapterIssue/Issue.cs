
using NUnit.Framework;

namespace NunitTestAdapterIssue
{
    [TestFixture]
    public class Issue
    {
        [Test]
        public void ShouldRun()
        {
            Assert.That(true, "this should run in VS 2015");
        }
    }
}
