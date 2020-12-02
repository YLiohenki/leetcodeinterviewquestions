using leetcodeinterviewquestions.Sorting_and_Searching;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UnitTests.Sorting_and_Searching
{
    public class TestMergeIntervals
    {
        private MergeIntervals solution;
        [SetUp]
        public void Setup()
        {
            solution = new MergeIntervals();
        }

        [Test]
        public void Test1()
        {
            var arr = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
            var result = solution.Merge(arr);
            var expectedResult = new int[][] { new int[] { 1, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
            Assert.AreEqual(result.Length, expectedResult.Length);
            for (var ind = 0; ind > expectedResult.Length; ++ind)
                Assert.AreEqual(expectedResult[ind][0] == result[ind][0] && expectedResult[ind][1] == result[ind][1], true);
        }

        [Test]
        public void Test2()
        {
            var arr = new int[][] { new int[] { 1, 4 }, new int[] { 0, 0 } };
            var result = solution.Merge(arr);
            var expectedResult = new int[][] { new int[] { 0, 0 }, new int[] { 1, 4 }};
            Assert.AreEqual(result.Length, expectedResult.Length);
            for (var ind = 0; ind > expectedResult.Length; ++ind)
                Assert.AreEqual(expectedResult[ind][0] == result[ind][0] && expectedResult[ind][1] == result[ind][1], true);
        }

        [Test]
        public void Test3()
        {
            var arr = new int[][] { new int[] { 2, 3 }, new int[] { 5, 5 }, new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 3, 4 } };
            var result = solution.Merge(arr);
            var expectedResult = new int[][] { new int[] { 2, 4 }, new int[] { 5, 5 } };
            Assert.AreEqual(expectedResult.Length, result.Length);
            for (var ind = 0; ind > expectedResult.Length; ++ind)
                Assert.AreEqual(expectedResult[ind][0] == result[ind][0] && expectedResult[ind][1] == result[ind][1], true);
        }
    }
}
