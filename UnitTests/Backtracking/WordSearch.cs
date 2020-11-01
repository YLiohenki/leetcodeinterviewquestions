using leetcodeinterviewquestions.Backtracking;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests.Backtracking
{
    public class TestWordSearch
    {
        private WordSearch solution;
        [SetUp]
        public void Setup()
        {
            solution = new WordSearch();
        }

        public char[][] strToCharArrArr(string input)
        {
            return input.Split("],[").Select(str => str.Replace("]", "").Replace("[", "").Replace("'", "").Split(",").Select(s => s[0]).ToArray()).ToArray();
        }

        [Test]
        public void Test1()
        {
            var result = solution.Exist(strToCharArrArr("[['A','B','C','E'],['S','F','C','S'],['A','D','E','E']]"), "ABCCED");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.Exist(strToCharArrArr("[['A','B','C','E'],['S','F','C','S'],['A','D','E','E']]"), "SEE");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test3()
        {
            var result = solution.Exist(strToCharArrArr("[['A','B','C','E'],['S','F','C','S'],['A','D','E','E']]"), "ABCB");
            Assert.AreEqual(false, result);
        }
    }
}
