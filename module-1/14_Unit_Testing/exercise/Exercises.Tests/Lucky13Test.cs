using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void GetLuckyTest()
        {
            Lucky13 testObject = new Lucky13();

            bool result = testObject.GetLucky(new int[] { 1, 2, 5 });

            Assert.IsFalse(result);
        }
    }
}
