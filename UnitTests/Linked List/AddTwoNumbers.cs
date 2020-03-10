using leetcodeinterviewquestions.Linked_List;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Linked_List
{
    public class AddTwoNumbers
    {
        private AddTwoNumbersSolution solution;
        [SetUp]
        public void Setup()
        {
            solution = new AddTwoNumbersSolution();
        }

        [Test]
        public void Test1()
        {
            var result = solution.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))));
            Assert.AreEqual(7, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(8, result.next.next.val);
        }
    }
}
