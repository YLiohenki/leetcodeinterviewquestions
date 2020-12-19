using leetcodeinterviewquestions.Design;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Design
{
    public class TestRandomizedSet
    {
        private RandomizedSet solution;
        [SetUp]
        public void Setup()
        {
            solution = new RandomizedSet();
        }

        [Test]
        public void Test1()
        {
            var result = solution.Insert(0);
            Assert.AreEqual(true, result);
            result = solution.Insert(0);
            Assert.AreEqual(false, result);
            result = solution.Insert(1);
            Assert.AreEqual(true, result);
            result = solution.Insert(2);
            Assert.AreEqual(true, result);
            result = solution.Insert(3);
            Assert.AreEqual(true, result);
            var randRes = solution.GetRandom();
        }
    }
}
