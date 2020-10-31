using leetcodeinterviewquestions.Backtracking;
using NUnit.Framework;

namespace UnitTests.Backtracking
{
    public class TestsLetterCombinationsofaPhoneNumber
    {
        private LetterCombinationsofaPhoneNumber solution;
        [SetUp]
        public void Setup()
        {
            solution = new LetterCombinationsofaPhoneNumber();
        }

        [Test]
        public void Test1()
        {
            var result = solution.LetterCombinations("23");
            Assert.AreEqual(9, result.Count);
        }

        [Test]
        public void Test2()
        {
            var result = solution.LetterCombinations("");
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void Test3()
        {
            var result = solution.LetterCombinations("2");
            Assert.AreEqual(3, result.Count);
        }
    }
}
