using leetcodeinterviewquestions.Backtracking;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Backtracking
{
    public class TestsPermutations
    {
        private Permutations solution;
        [SetUp]
        public void Setup()
        {
            solution = new Permutations();
        }

        [Test]
        public void Test1()
        {
            var result = solution.Permute(new int[] { 1, 2, 3 });
            Assert.AreEqual(6, result.Count);
        }

        [Test]
        public void Test2()
        {
            var result = solution.Permute(new int[] { 1, 2 });
            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public void Test3()
        {
            var result = solution.Permute(new int[] { 1 });
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void Test4()
        {
            var result = solution.Permute(new int[] { });
            Assert.AreEqual(0, result.Count);
        }
    }
}

