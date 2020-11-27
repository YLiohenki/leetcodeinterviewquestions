using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcodeinterviewquestions.Sorting_and_Searching
{
    public class KthLargestElementinanArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            return nums.OrderByDescending(n => n).Skip(k -1).First();
        }
    }
}
