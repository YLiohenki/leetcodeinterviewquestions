using leetcodeinterviewquestions.Dynamic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Dynamic
{
    public class CoinChange
    {
        private CoinChangeSolution solution;
        [SetUp]
        public void Setup()
        {
            solution = new CoinChangeSolution();
        }

        [Test]
        public void Test1()
        {
            var coins = new int[] { 1, 2, 5 };
            var result = solution.CoinChange(coins, 11);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test2()
        {
            var coins = new int[] { 2 };
            var result = solution.CoinChange(coins, 3);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test3()
        {
            var coins = new int[] { 1 };
            var result = solution.CoinChange(coins, 0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test4()
        {
            var coins = new int[] { 1 };
            var result = solution.CoinChange(coins, 1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test5()
        {
            var coins = new int[] { 1 };
            var result = solution.CoinChange(coins, 2);
            Assert.AreEqual(2, result);
        }
    }
}
