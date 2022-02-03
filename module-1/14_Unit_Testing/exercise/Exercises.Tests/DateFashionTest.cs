using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        [TestMethod]
        public void GetATableTest()
        {
            DateFashion testObject = new DateFashion();

            int result = testObject.GetATable(3, 9);

            Assert.AreEqual(2, result);
        }
    }
}
