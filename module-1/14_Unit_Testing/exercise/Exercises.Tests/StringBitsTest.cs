using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void GetBitsTest()
        {
            StringBits testObject = new StringBits();

            string result = testObject.GetBits("HeellllooWWoorrlldd");

            Assert.AreEqual("HelloWorld", result);
        }
    }
}
