using leetcodeinterviewquestions.Dynamic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Dynamic
{
    public class TestJumpGame
    {
        private JumpGame solution;
        [SetUp]
        public void Setup()
        {
            solution = new JumpGame();
        }

        [Test]
        public void Test1()
        {
            var input = new int[] { 2, 3, 1, 1, 4 };
            var result = solution.CanJump(input);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test2()
        {
            var input = new int[] { 3, 2, 1, 0, 4 };
            var result = solution.CanJump(input);
            Assert.AreEqual(false, result);
        }
    }
}
