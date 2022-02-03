using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void HavePartyTest()
        {
            CigarParty testObject = new CigarParty();

            bool result = testObject.HaveParty(61, false);

            Assert.IsFalse(result);
        }
    }
}
