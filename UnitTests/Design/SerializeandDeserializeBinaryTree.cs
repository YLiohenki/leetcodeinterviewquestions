using leetcodeinterviewquestions.Design;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using static leetcodeinterviewquestions.Design.SerializeandDeserializeBinaryTree;

namespace UnitTests.Design
{
    public class TestsSerializeandDeserializeBinaryTree
    {
        private SerializeandDeserializeBinaryTree solution;
        [SetUp]
        public void Setup()
        {
            solution = new SerializeandDeserializeBinaryTree();
        }

        public bool CompareTrees(TreeNode tree1, TreeNode tree2)
        {
            if (tree1 == null || tree2 == null)
                return tree1 == tree2;
            return tree1.val == tree2.val && ((tree1.left == null && tree2.left == null) || CompareTrees(tree1.left, tree2.left))
                && ((tree1.right == null && tree2.right == null) || CompareTrees(tree1.right, tree2.right));
        }

        [Test]
        public void Test1()
        {
            var tree = solution.deserialize("1,-,-");
            var result = solution.deserialize(solution.serialize(tree));
            Assert.AreEqual(true, CompareTrees(result,tree));
        }
        [Test]
        public void Test2()
        {
            var tree = solution.deserialize("");
            var result = solution.deserialize(solution.serialize(tree));
            Assert.AreEqual(true, CompareTrees(result, tree));
        }
        [Test]
        public void Test3()
        {
            var tree = solution.deserialize("1,2,-,-,3,4,-,-,5,-,-");
            var result = solution.deserialize(solution.serialize(tree));
            Assert.AreEqual(true, CompareTrees(result, tree));
        }
    }
}
