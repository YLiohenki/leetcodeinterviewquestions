using leetcodeinterviewquestions.Sorting_and_Searching;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Sorting_and_Searching
{
    public class TestSearcha2DMatrixII
    {
        private Searcha2DMatrixII solution;
        [SetUp]
        public void Setup()
        {
            solution = new Searcha2DMatrixII();
        }

        [Test]
        public void Test1()
        {
            var arr = new int[][] { new int[] { 1, 4, 7, 11, 15 }, new int[] { 2, 5, 8, 12, 19 }, new int[] { 3, 6, 9, 16, 22 }, new int[] { 10, 13, 14, 17, 24 }, new int[] { 18, 21, 23, 26, 30 } };
            var result = solution.SearchMatrix(arr, 5);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test2()
        {
            var arr = new int[][] { new int[] { 1, 4, 7, 11, 15 }, new int[] { 2, 5, 8, 12, 19 }, new int[] { 3, 6, 9, 16, 22 }, new int[] { 10, 13, 14, 17, 24 }, new int[] { 18, 21, 23, 26, 30 } };
            var result = solution.SearchMatrix(arr, 20);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void Test3()
        {
            var arr = new int[][] { new int[] { -5 } };
            var result = solution.SearchMatrix(arr, -5);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test4()
        {
            var arr = new int[][] { new int[] { 1, 1 } };
            var result = solution.SearchMatrix(arr, 2);
            Assert.AreEqual(false, result);
        }
    }
}
