using leetcodeinterviewquestions.Trees_and_Graphs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Trees_and_Graphs
{
    public class BinaryTreeZigzagLevelOrderTraversalTest
    {
        private BinaryTreeZigzagLevelOrderTraversal solution;
        [SetUp]
        public void Setup()
        {
            solution = new BinaryTreeZigzagLevelOrderTraversal();
        }

        [Test]
        public void Test1()
        {
            var result = solution.ZigzagLevelOrder(new TreeNode(3) { left = new TreeNode(9), right = new TreeNode(20) { left = new TreeNode(15), right = new TreeNode(7) } });
            Assert.AreEqual(new int[] { 3 }, result[0]);
            Assert.AreEqual(new int[] { 20, 9 }, result[1]);
            Assert.AreEqual(new int[] { 15, 7 }, result[2]);
            Assert.AreEqual(3, result.Count);
        }

        [Test]
        public void Test2()
        {
            var result = solution.ZigzagLevelOrder(new TreeNode(1) { left = new TreeNode(2) { left = new TreeNode(4) }, right = new TreeNode(3) { right = new TreeNode(5) } });
            Assert.AreEqual(new int[] { 1 }, result[0]);
            Assert.AreEqual(new int[] { 3, 2 }, result[1]);
            Assert.AreEqual(new int[] { 4, 5 }, result[2]);
            Assert.AreEqual(3, result.Count);
        }
    }
}
