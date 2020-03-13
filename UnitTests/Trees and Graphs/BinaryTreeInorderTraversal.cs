using leetcodeinterviewquestions.Trees_and_Graphs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Trees_and_Graphs
{
    public class BinaryTreeInorderTraversalTest
    {
        private BinaryTreeInorderTraversal solution;
        [SetUp]
        public void Setup()
        {
            solution = new BinaryTreeInorderTraversal();
        }

        [Test]
        public void Test1()
        {
            var result = solution.InorderTraversal(new TreeNode(1) { right = new TreeNode(2) { left = new TreeNode(3) } });
            Assert.AreEqual(new int[] { 1, 3, 2 }, result);
        }
    }
}
