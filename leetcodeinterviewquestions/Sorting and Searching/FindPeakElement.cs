using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Sorting_and_Searching
{
    public class FindPeakElementSolution
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums.Length == 1)
                return 0;
            if (nums[0] > nums[1])
                return 0;
            if (nums[nums.Length - 1] > nums[nums.Length - 2])
                return nums.Length - 1;
            var start = 0;
            var end = nums.Length - 1;
            var middle = (start + end) / 2;
            while ((middle - 1 >= 0 && nums[middle - 1] > nums[middle]) || (middle + 1 < nums.Length && nums[middle + 1] > nums[middle]))
            {
                if (nums[start] > nums[middle])
                {
                    end = middle;
                }
                else if (nums[end] > nums[middle])
                {
                    start = middle;
                }
                else if (nums[middle - 1] > nums[middle])
                {
                    end = middle;
                }
                else {
                    start = middle;
                }
                middle = (start + end) / 2;
            }
            return middle;
        }
    }
}
