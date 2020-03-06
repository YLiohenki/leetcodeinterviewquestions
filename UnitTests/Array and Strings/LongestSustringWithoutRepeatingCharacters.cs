using leetcodeinterviewquestions.Array_and_Strings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Array_and_Strings
{
    public class Tests
    {
        private LongestSustringWithoutRepeatingCharacters solution;
        [SetUp]
        public void Setup()
        {
            solution = new LongestSustringWithoutRepeatingCharacters();
        }

        [Test]
        public void Test1()
        {
            var result = solution.LengthOfLongestSubstring("abcabcbb");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.LengthOfLongestSubstring("bbbbb");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test3()
        {
            var result = solution.LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test4()
        {
            var result = solution.LengthOfLongestSubstring("tmmzuxt");
            Assert.AreEqual(5, result);
        }
    }
}
