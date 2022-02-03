using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]
        public void MakeArrayTest()
        {
            MaxEnd3 testObject = new MaxEnd3();

            int[] result = testObject.MakeArray(new int[] { 12, 9, 6 });

            CollectionAssert.AreEqual(new int[] { 12, 12, 12 }, result);
        }
    }
}
