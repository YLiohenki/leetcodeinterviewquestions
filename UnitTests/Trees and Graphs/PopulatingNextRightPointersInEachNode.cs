using leetcodeinterviewquestions.Trees_and_Graphs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Trees_and_Graphs
{
    public class PopulatingNextRightPointersInEachNodeTest
    {
        private PopulatingNextRightPointersInEachNode solution;
        [SetUp]
        public void Setup()
        {
            solution = new PopulatingNextRightPointersInEachNode();
        }

        [Test]
        public void Test1()
        {
            var result = solution.Connect(new Node(1, new Node(2, new Node(4), new Node(5), null), new Node(3, new Node(6), new Node(7), null), null));
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(null, result.next);
            Assert.AreEqual(3, result.left.next.val);
            Assert.AreEqual(null, result.right.next);
            Assert.AreEqual(5, result.left.left.next.val);
            Assert.AreEqual(6, result.left.right.next.val);
            Assert.AreEqual(7, result.right.left.next.val);
            Assert.AreEqual(null, result.right.right.next);
        }
    }
}
