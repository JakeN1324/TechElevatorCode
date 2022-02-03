using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void GetHerTest()
        {
            AnimalGroupName testObject = new AnimalGroupName();

            string result = testObject.GetHerd("Rhino");

            Assert.AreEqual("Crash", result);
        }
    }
}
