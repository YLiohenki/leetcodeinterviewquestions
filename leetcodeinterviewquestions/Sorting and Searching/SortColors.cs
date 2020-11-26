using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Sorting_and_Searching
{
    public class SortColorsSolution
    {
        public void SortColors(int[] nums)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (end >= 0 && nums[end] == 2)
                end--;
            while (start < nums.Length && nums[start] == 0)
                start++;
            for (var i = start; i <= end && start < end; ++i)
            {
                if (i < start) i = start;
                if (nums[i] == 2)
                {
                    nums[i] = nums[end];
                    nums[end] = 2;
                    end--;
                }
                if (i > start && nums[i] == 0)
                {
                    nums[i] = nums[start];
                    nums[start] = 0;
                    start++;
                }
                while (start < nums.Length && nums[start] == 0)
                    start++;
                while (end >= 0 && nums[end] == 2)
                    end--;
            }
        }
    }
}
