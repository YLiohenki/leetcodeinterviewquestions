using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Array_and_Strings
{
    public class IncreasingTripletSubsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3)
                return false;
            var maxAfter = new int[nums.Length];
            var minBefore = new int[nums.Length];
            var min = nums[0];
            var max = nums[nums.Length - 1];
            for (int i = 0; i < nums.Length; ++i)
            {
                if (min > nums[i])
                    min = nums[i];
                minBefore[i] = min;
            }

            for (int i = nums.Length - 1; i >= 0; --i)
            {
                if (max < nums[i])
                    max = nums[i];
                maxAfter[i] = max;
            }
            for (int i = 0; i < nums.Length; ++i)
            {
                if (minBefore[i] < nums[i] && nums[i] < maxAfter[i])
                    return true;
            }
            return false;
        }
    }
}
