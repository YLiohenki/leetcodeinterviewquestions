using leetcodeinterviewquestions.Math_Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Math_Problems
{
    public class TestSqrt_x
    {
        private Sqrt_x solution;
        [SetUp]
        public void Setup()
        {
            solution = new Sqrt_x();
        }

        [Test]
        public void Test1()
        {
            var result = solution.MySqrt(4);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.MySqrt(8);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Test3()
        {
            var result = solution.MySqrt(1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test4()
        {
            var result = solution.MySqrt(2147395599);
            Assert.AreEqual(46339, result);
        }

        [Test]
        public void Test5()
        {
            var result = solution.MySqrt(2147395600);
            Assert.AreEqual(46340, result);
        }

        [Test]
        public void Test6()
        {
            var result = solution.MySqrt(29792276);
            Assert.AreEqual(5458, result);
        }
    }
}
