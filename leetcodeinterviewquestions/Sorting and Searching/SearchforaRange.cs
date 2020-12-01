using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Sorting_and_Searching
{
    public class SearchforaRange
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            var middle = (start + end) / 2;

            while (start != end && end < nums.Length && start < nums.Length && end >= 0 && start >= 0)
            {
                if (nums[middle] < target)
                {
                    start = middle + 1;
                }
                else if (nums[middle] > target)
                {
                    end = middle - 1;
                }
                else
                {
                    if (middle - 1 >= 0 && nums[middle - 1] == target)
                        end = middle - 1;
                    else
                        end = middle;
                }
                middle = (start + end) / 2;

            }
            var result = new int[2];
            result[0] = start;

            start = 0;
            end = nums.Length - 1;
            middle = (start + end) / 2;

            while (start != end && end < nums.Length && start < nums.Length && end >= 0 && start >= 0)
            {
                if (nums[middle] > target)
                {
                    end = middle - 1;
                }
                else if (nums[middle] < target)
                {
                    start = middle + 1;
                }
                else
                {
                    if (middle + 1 < nums.Length && nums[middle + 1] == target)
                        start = middle + 1;
                    else
                        start = middle;
                }
                middle = (start + end + 1) / 2;
            }

            result[1] = start;

            if (result[0] >= nums.Length || result[1] >= nums.Length || nums[result[0]] != target || nums[result[1]] != target)
                return new int[] { -1, -1 };
            return result;
        }
    }
}
