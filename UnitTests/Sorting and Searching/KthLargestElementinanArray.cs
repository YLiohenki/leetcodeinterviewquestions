using leetcodeinterviewquestions.Sorting_and_Searching;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Sorting_and_Searching
{
    public class TestKthLargestElementinanArray
    {
        private KthLargestElementinanArray solution;

        [SetUp]
        public void Setup()
        {
            solution = new KthLargestElementinanArray();
        }

        [Test]
        public void Test1()
        {
            var arr = new int[] { 3, 2, 1, 5, 6, 4 };
            var result = solution.FindKthLargest(arr, 2);
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void Test2()
        {
            var arr = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            var result = solution.FindKthLargest(arr, 4);
            Assert.AreEqual(result, 4);
        }
    }
}
