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

        [TestMethod]
        public void TestMethod2()
        {
            var sut = new Worker();
            var input = 4;
            Assert.AreEqual(input + 1, sut.AddOne(input));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var sut = new Worker();
            var input = 7;
            Assert.AreEqual(input + 2, sut.AddTwo(input));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var sut = new Worker();
            var input = "thisismystring";
            Assert.AreEqual("thi", sut.Cut(input));
        }
    }
}
