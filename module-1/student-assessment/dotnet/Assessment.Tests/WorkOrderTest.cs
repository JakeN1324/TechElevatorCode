
using Assessment.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class WorkOrderTest
    {
        [TestMethod]
        public void EstimatedTotalTest()
        {
            WorkOrder testObject = new WorkOrder("name", 50, 20);

            decimal result = testObject.EstimatedTotal;

            Assert.AreEqual(49.90M, result);
        }

        [TestMethod]
        public void ActualTotalTest()
        {
            WorkOrder testObject = new WorkOrder("name", 50, 20);

            decimal result = testObject.ActualTotal(true, true);

            Assert.AreEqual(108.61M, result);
        }
    }
}
