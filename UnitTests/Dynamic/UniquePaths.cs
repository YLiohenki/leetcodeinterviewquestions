using leetcodeinterviewquestions.Dynamic;
using NUnit.Framework;

namespace UnitTests.Dynamic
{
    public class TestUniquePaths
    {
        private UniquePathsSolution solution;
        [SetUp]
        public void Setup()
        {
            solution = new UniquePathsSolution();
        }

        [Test]
        public void Test1()
        {
            var result = solution.UniquePaths(3, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.UniquePaths(7, 3);
            Assert.AreEqual(28, result);
        }

        [Test]
        public void Test3()
        {
            var result = solution.UniquePaths(3, 3);
            Assert.AreEqual(6, result);
        }
    }
}
