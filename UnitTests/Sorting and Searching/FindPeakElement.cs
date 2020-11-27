using leetcodeinterviewquestions.Sorting_and_Searching;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Sorting_and_Searching
{
    public class TestFindPeakElement
    {
        private FindPeakElementSolution solution;

        [SetUp]
        public void Setup()
        {
            solution = new FindPeakElementSolution();
        }

        [Test]
        public void Test1()
        {
            var arr = new int[] { 1, 2, 3, 1 };
            var index = solution.FindPeakElement(arr);
            Assert.AreEqual(index, 2);
        }

        [Test]
        public void Test2()
        {
            var arr = new int[] { 1, 2, 1, 3, 5, 6, 4 };
            var index = solution.FindPeakElement(arr);
            Assert.AreEqual(index == 1 || index == 5, true);
        }
        [Test]
        public void Test3()
        {
            var arr = new int[] { 1, 6, 5, 4, 3, 2, 1 };
            var index = solution.FindPeakElement(arr);
            Assert.AreEqual(index, 1);
        }
    }
}
