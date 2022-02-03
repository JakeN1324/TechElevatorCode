using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void GetCountTest()
        {
            WordCount testObject = new WordCount();

            Dictionary<string, int> result = testObject.GetCount(new string[] { "a", "a", "b", "b", "b", "c" });

            CollectionAssert.AreEqual(new Dictionary<string, int>()
            {
                {"a", 2 },
                {"b", 3 },
                {"c", 1 }
            }, result);
        }
    }
}
