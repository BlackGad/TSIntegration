using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace SimpleApplication.Tests.Tests
{
    [TestFixture]
    public class SomeReasonableLogic_Tests
    {
        [Test]
        public void Successful_Test()
        {
            var logic = new SomeReasonableLogic();
            Assert.AreEqual(43, logic.RequestAnswer());
        }
    }
}
