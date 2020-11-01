using leetcodeinterviewquestions.Backtracking;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Backtracking
{
    public class TestsSubsets
    {
        private SubsetsSolution solution;
        [SetUp]
        public void Setup()
        {
            solution = new SubsetsSolution();
        }

        [Test]
        public void Test1()
        {
            var result = solution.Subsets(new int[] { 1, 2, 3 });
            Assert.AreEqual(8, result.Count);
        }

        [Test]
        public void Test2()
        {
            var result = solution.Subsets(new int[] { 1 });
            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public void Test3()
        {
            var result = solution.Subsets(new int[] { 1, 2 });
            Assert.AreEqual(4, result.Count);
        }

        [Test]
        public void Test4()
        {
            var result = solution.Subsets(new int[] { });
            Assert.AreEqual(1, result.Count);
        }
    }
}
