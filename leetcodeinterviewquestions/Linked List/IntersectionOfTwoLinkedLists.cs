using System;
using System.Collections.Generic;
using System.Text;

// https://leetcode.com/explore/interview/card/top-interview-questions-medium/107/linked-list/785/

namespace leetcodeinterviewquestions.Linked_List
{
    public class IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            var pA = headA;
            var lenA = 0;
            while (pA != null)
            {
                lenA++;
                pA = pA.next;
            }
            var pB = headB;
            var lenB = 0;
            while (pB != null)
            {
                lenB++;
                pB = pB.next;
            }
            if (pA != pB)
                return null;
            pA = headA;
            pB = headB;
            while (lenA != lenB)
            {
                if (lenA > lenB)
                {
                    lenA--;
                    pA = pA.next;
                }
                else {
                    lenB--;
                    pB = pB.next;
                }
            }

            while (pA != null && pB != null)
            {
                if (pA == pB)
                    return pA;
                pA = pA.next;
                pB = pB.next;
            }
            return null;
        }
    }
}
