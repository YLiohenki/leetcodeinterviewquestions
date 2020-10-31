using leetcodeinterviewquestions.Backtracking;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Backtracking
{
    public class TestsGenerateParentheses
    {
        private GenerateParentheses solution;
        [SetUp]
        public void Setup()
        {
            solution = new GenerateParentheses();
        }

        [Test]
        public void Test1()
        {
            var result = solution.GenerateParenthesis(1);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("()", result[0]);
        }

        [Test]
        public void Test2()
        {
            var result = solution.GenerateParenthesis(0);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void Test3()
        {
            var result = solution.GenerateParenthesis(3);
            Assert.AreEqual(5, result.Count);
        }

        [Test]
        public void Test4()
        {
            var result = solution.GenerateParenthesis(2);
            Assert.AreEqual(2, result.Count);
        }
    }
}
