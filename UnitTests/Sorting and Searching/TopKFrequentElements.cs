using leetcodeinterviewquestions.Sorting_and_Searching;
using NUnit.Framework;
using System.Linq;

namespace UnitTests.Sorting_and_Searching
{
    class TestTopKFrequentElements
    {
        private TopKFrequentElements solution;

        [SetUp]
        public void Setup()
        {
            solution = new TopKFrequentElements();
        }

        [Test]
        public void Test1()
        {
            var arr = new int[] { 1, 2, 0, 0, 0, 2, 1 };
            var result = solution.TopKFrequent(arr, 1);
            Assert.AreEqual(result.Length, 1);
            Assert.AreEqual(result.Any(a => a == 0), true);
        }

        [Test]
        public void Test2()
        {
            var arr = new int[] { 1, 1, 1, 2, 2, 3 };
            var result = solution.TopKFrequent(arr, 2);
            Assert.AreEqual(result.Length, 2);
            Assert.AreEqual(result.Any(a => a == 1), true);
            Assert.AreEqual(result.Any(a => a == 2), true);
        }

        [Test]
        public void Test3()
        {
            var arr = new int[] { 1 };
            var result = solution.TopKFrequent(arr, 1);
            Assert.AreEqual(result.Length, 1);
            Assert.AreEqual(result.Any(a => a == 1), true);
        }
    }
}
