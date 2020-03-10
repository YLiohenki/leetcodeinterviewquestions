using System;
using System.Collections.Generic;
using System.Text;

// https://leetcode.com/explore/interview/card/top-interview-questions-medium/107/linked-list/784/

namespace leetcodeinterviewquestions.Linked_List
{
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
                return head;
            var oddPoint = head;
            var evenPoint = head.next;
            var evenPointStart = evenPoint;

            var p = head.next;
            var odd = true;
            while (p.next != null)
            {
                p = p.next;
                if (odd)
                {
                    oddPoint.next = p;
                    oddPoint = p;
                }
                else
                {
                    evenPoint.next = p;
                    evenPoint = p;
                }
                odd = !odd;
            }

            oddPoint.next = evenPointStart;
            evenPoint.next = null;

            return head;
        }
    }
}
