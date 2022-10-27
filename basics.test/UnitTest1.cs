using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace basics
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Worker();
            Assert.IsTrue(sut.DoStuff());
        }
    }
}
