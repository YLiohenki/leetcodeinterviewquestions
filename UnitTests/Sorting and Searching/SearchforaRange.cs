using leetcodeinterviewquestions.Sorting_and_Searching;
using NUnit.Framework;

namespace UnitTests.Sorting_and_Searching
{
    public class TestSearchforaRange
    {
        private SearchforaRange solution;
        [SetUp]
        public void Setup()
        {
            solution = new SearchforaRange();
        }

        [Test]
        public void Test1()
        {
            var arr = new int[] { 5, 7, 7, 8, 8, 10 };
            var result = solution.SearchRange(arr, 8);
            Assert.AreEqual(result[0], 3);
            Assert.AreEqual(result[1], 4);
        }

        [Test]
        public void Test2()
        {
            var arr = new int[] { 5, 7, 7, 8, 8, 10 };
            var result = solution.SearchRange(arr, 6);
            Assert.AreEqual(result[0], -1);
            Assert.AreEqual(result[1], -1);
        }

        [Test]
        public void Test3()
        {
            var arr = new int[] { };
            var result = solution.SearchRange(arr, 0);
            Assert.AreEqual(result[0], -1);
            Assert.AreEqual(result[1], -1);
        }

        [Test]
        public void Test4()
        {
            var arr = new int[] { 2, 2 };
            var result = solution.SearchRange(arr, 1);
            Assert.AreEqual(result[0], -1);
            Assert.AreEqual(result[1], -1);
        }
    }
}
