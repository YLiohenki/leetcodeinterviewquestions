using leetcodeinterviewquestions.Dynamic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Dynamic
{
    public class TestLongestIncreasingSubsequence
    {
        private LongestIncreasingSubsequence solution;
        [SetUp]
        public void Setup()
        {
            solution = new LongestIncreasingSubsequence();
        }

        [Test]
        public void Test1()
        {
            var input = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            var result = solution.LengthOfLIS(input);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test2()
        {
            var input = new int[] { 0, 1, 0, 3, 2, 3 };
            var result = solution.LengthOfLIS(input);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test3()
        {
            var input = new int[] { 7, 7, 7, 7, 7, 7, 7 };
            var result = solution.LengthOfLIS(input);
            Assert.AreEqual(1, result);
        }
    }
}
