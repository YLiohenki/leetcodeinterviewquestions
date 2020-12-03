using leetcodeinterviewquestions.Sorting_and_Searching;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Sorting_and_Searching
{
    public class TestSearchinRotatedSortedArray
    {
        private SearchinRotatedSortedArray solution;
        [SetUp]
        public void Setup()
        {
            solution = new SearchinRotatedSortedArray();
        }

        [Test]
        public void Test1()
        {
            var arr = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var result = solution.Search(arr, 0);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test2()
        {
            var arr = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var result = solution.Search(arr, 3);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test3()
        {
            var arr = new int[] { 1 };
            var result = solution.Search(arr, 0);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test4()
        {
            var arr = new int[] { 4, 5, 6, 7, 0, 1, 2};
            var result = solution.Search(arr, 4);
            Assert.AreEqual(0, result);
        }
    }
}
