using System;
using System.Collections.Generic;
using System.Text;


// https://leetcode.com/explore/interview/card/top-interview-questions-medium/107/linked-list/783/

namespace leetcodeinterviewquestions.Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public ListNode(int x, ListNode next) { val = x; this.next = next; }
    }
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode curres = null;
            var curl1 = l1;
            var curl2 = l2;
            var moveNum = 0;
            while (curl1 != null || curl2 != null)
            {
                var nextNum = moveNum + (curl1 != null ? curl1.val : 0) + (curl2 != null ? curl2.val : 0);
                if (nextNum >= 10)
                {
                    nextNum -= 10;
                    moveNum = 1;
                }
                else
                {
                    moveNum = 0;
                }
                if (result == null)
                {
                    result = new ListNode(nextNum);
                    curres = result;
                }
                else
                {
                    curres.next = new ListNode(nextNum);
                    curres = curres.next;
                }
                curl1 = curl1?.next;
                curl2 = curl2?.next;
            }
            if (moveNum > 0)
            {
                curres.next = new ListNode(moveNum);
            }
            return result;
        }
    }
}
