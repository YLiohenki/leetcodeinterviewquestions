using leetcodeinterviewquestions.Math_Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Math_Problems
{
    public class TestDivideTwoIntegers
    {
        private DivideTwoIntegers solution;
        [SetUp]
        public void Setup()
        {
            solution = new DivideTwoIntegers();
        }

        [Test]
        public void Test1()
        {
            var result = solution.Divide(-2147483648,-1);
            Assert.AreEqual(2147483647, result);
        }
    }
}
