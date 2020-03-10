using leetcodeinterviewquestions.Linked_List;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Linked_List
{
    public class IntersectionOfTwoLinkedListsTest
    {
        private IntersectionOfTwoLinkedLists solution;
        [SetUp]
        public void Setup()
        {
            solution = new IntersectionOfTwoLinkedLists();
        }

        [Test]
        public void Test1()
        {
            var sharedList = new ListNode(8, new ListNode(4, new ListNode(5)));
            var listA = new ListNode(4, new ListNode(1, sharedList));
            var listB = new ListNode(5, new ListNode(0, new ListNode(1, sharedList)));
            var result = solution.GetIntersectionNode(listA, listB);
            Assert.AreEqual(8, result.val);
        }

        [Test]
        public void Test2()
        {
            var sharedList = new ListNode(2, new ListNode(4));
            var listA = new ListNode(0, new ListNode(9, new ListNode(1, sharedList)));
            var listB = new ListNode(3, sharedList);
            var result = solution.GetIntersectionNode(listA, listB);
            Assert.AreEqual(2, result.val);
        }

        [Test]
        public void Test3()
        {
            var listA = new ListNode(2, new ListNode(6, new ListNode(4)));
            var listB = new ListNode(3, new ListNode(5));
            var result = solution.GetIntersectionNode(listA, listB);
            Assert.AreEqual(null, result);
        }
    }
}
