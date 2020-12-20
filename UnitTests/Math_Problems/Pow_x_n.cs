using leetcodeinterviewquestions.Math_Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Math_Problems
{
    public class TestPow_x_n
    {
        private Pow_x_n solution;
        [SetUp]
        public void Setup()
        {
            solution = new Pow_x_n();
        }

        [Test]
        public void Test1()
        {
            var result = solution.MyPow(2.0, 10);
            Assert.AreEqual(1024.0, result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.MyPow(2.1, 3);
            Assert.AreEqual(9.26100, result, 0.0001);
        }

        [Test]
        public void Test3()
        {
            var result = solution.MyPow(2.00000, -2);
            Assert.AreEqual(0.25000, result, 0.0001);
        }

        [Test]
        public void Test4()
        {
            var result = solution.MyPow(0.00001, 2147483647);
            Assert.AreEqual(0.00, result, 0.0001);
        }

        [Test]
        public void Test5()
        {
            var result = solution.MyPow(2.000, -2147483648);
            Assert.AreEqual(0.00, result, 0.0001);
        }
    }
}
