using leetcodeinterviewquestions.Array_and_Strings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Array_and_Strings
{
    public class TestLongestPalindromicSubstring
    {
        private LongestPalindromicSubstring solution;
        [SetUp]
        public void Setup()
        {
            solution = new LongestPalindromicSubstring();
        }

        [Test]
        public void Test1()
        {
            var result = solution.LongestPalindrome("babad");
            Assert.AreEqual("bab", result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.LongestPalindrome("cbbd");
            Assert.AreEqual("bb", result);
        }

        [Test]
        public void Test3()
        {
            var result = solution.LongestPalindrome("cbbasdfggfdsad");
            Assert.AreEqual("asdfggfdsa", result);
        }

        [Test]
        public void Test4()
        {
            var result = solution.LongestPalindrome("bb");
            Assert.AreEqual("bb", result);
        }
    }
}
