using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void GenerateStringTest()
        {
            FrontTimes testObject = new FrontTimes();

            string result = testObject.GenerateString("Chocolate", 4);

            Assert.AreEqual("ChoChoChoCho", result);
        }
    }
}
