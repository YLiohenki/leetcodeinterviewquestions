using leetcodeinterviewquestions.Math_Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Math_Problems
{
    public class TestFactorialTrailingZeroes
    {
        private FactorialTrailingZeroes solution;
        [SetUp]
        public void Setup()
        {
            solution = new FactorialTrailingZeroes();
        }

        [Test]
        public void Test1()
        {
            var result = solution.TrailingZeroes(3);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.TrailingZeroes(5);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test3()
        {
            var result = solution.TrailingZeroes(10);
            Assert.AreEqual(2, result);
        }
    }
}
