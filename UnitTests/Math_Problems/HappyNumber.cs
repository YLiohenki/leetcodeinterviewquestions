using leetcodeinterviewquestions.Math_Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Math_Problems
{
    public class TestHappyNumber
    {
        private HappyNumber solution;
        [SetUp]
        public void Setup()
        {
            solution = new HappyNumber();
        }

        [Test]
        public void Test1()
        {
            var result = solution.IsHappy(19);
            Assert.IsTrue(result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.IsHappy(2);
            Assert.IsFalse(result);
        }
    }
}
