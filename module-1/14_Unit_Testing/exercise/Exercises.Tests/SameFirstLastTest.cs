using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void IsItTheSameTest()
        {
            SameFirstLast testObject = new SameFirstLast();

            bool result = testObject.IsItTheSame(new int[] { 2, 5, 3, 2 });

            Assert.IsTrue(result);
        }
    }
}
