using leetcodeinterviewquestions.Array_and_Strings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Array_and_Strings
{
    public class TestIncreasingTripletSubsequence
    {
        private IncreasingTripletSubsequence solution;
        [SetUp]
        public void Setup()
        {
            solution = new IncreasingTripletSubsequence();
        }

        [Test]
        public void Test1()
        {
            var result = solution.IncreasingTriplet(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.IncreasingTriplet(new int[] { 5, 4, 3, 2, 1 });
            Assert.AreEqual(false, result);
        }
    }
}
