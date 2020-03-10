using leetcodeinterviewquestions.Linked_List;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Linked_List
{
    public class OddEvenLinkedListTest
    {
        private OddEvenLinkedList solution;
        [SetUp]
        public void Setup()
        {
            solution = new OddEvenLinkedList();
        }

        [Test]
        public void Test1()
        {
            var result = solution.OddEvenList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(3, result.next.val);
            Assert.AreEqual(5, result.next.next.val);
            Assert.AreEqual(2, result.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.val);
        }

        [Test]
        public void Test2()
        {
            var result = solution.OddEvenList(null);
            Assert.AreEqual(null, result);
        }
    }
}
