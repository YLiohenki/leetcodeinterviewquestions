using leetcodeinterviewquestions.Trees_and_Graphs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Trees_and_Graphs
{
    public class KthSmallestElementInBSTTest
    {
        private KthSmallestElementInBST solution;
        [SetUp]
        public void Setup()
        {
            solution = new KthSmallestElementInBST();
        }

        [Test]
        public void Test1()
        {
            var result = solution.KthSmallest(new TreeNode(3) { left = new TreeNode(1) { right = new TreeNode(2) }, right = new TreeNode(4) } , 1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.KthSmallest(new TreeNode(5) { left = new TreeNode(3) { left = new TreeNode(2) { left = new TreeNode(1) }, right = new TreeNode(4) }, right = new TreeNode(6) }, 3);
            Assert.AreEqual(3, result);
        }
    }
}
