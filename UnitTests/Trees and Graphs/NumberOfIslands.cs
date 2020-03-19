using leetcodeinterviewquestions.Trees_and_Graphs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests.Trees_and_Graphs
{
    public class NumberOfIslandsTest
    {
        private NumberOfIslands solution;
        [SetUp]
        public void Setup()
        {
            solution = new NumberOfIslands();
        }

        [Test]
        public void Test1()
        {
            var inputStr = @"11110
11010
11000
00000";
            var input = inputStr.Split(Environment.NewLine).Select(str => str.ToCharArray()).ToArray();
            var result = solution.NumIslands(input);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test2()
        {
            var inputStr = @"11000
11000
00100
00011";
            var input = inputStr.Split(Environment.NewLine).Select(str => str.ToCharArray()).ToArray();
            var result = solution.NumIslands(input);
            Assert.AreEqual(3, result);
        }
    }
}
