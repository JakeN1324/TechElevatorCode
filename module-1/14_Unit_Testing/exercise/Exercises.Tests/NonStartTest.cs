using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void GetPartialStringTest()
        {
            NonStart testObject = new NonStart();

            string result = testObject.GetPartialString("shotl", "java");

            Assert.AreEqual("hotlava", result);
        }
    }
}
