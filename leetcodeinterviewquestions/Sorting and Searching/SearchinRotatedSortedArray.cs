using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Sorting_and_Searching
{
    public class SearchinRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            var middle = (start + end) / 2;
            while (end - start > 4)
            {
                if (nums[start] <= target && target <= nums[middle])
                {
                    end = middle;
                    middle = (start + end) / 2;
                }
                else if (nums[middle] <= target && target <= nums[end])
                {
                    start = middle;
                    middle = (start + end) / 2;
                }
                else if (nums[start] > nums[middle])
                {
                    end = middle;
                    middle = (start + end) / 2;
                }
                else
                {
                    start = middle;
                    middle = (start + end) / 2;
                }
            }

            for (int i = start; i <= end; ++i)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
