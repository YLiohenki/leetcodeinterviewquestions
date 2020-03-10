using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// https://leetcode.com/explore/interview/card/top-interview-questions-medium/103/array-and-strings/776/

namespace leetcodeinterviewquestions.Array_and_Strings
{
    public class Sum3
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            nums = nums.OrderBy(o => o).ToArray();
            var result = new List<IList<int>>();
            for (var ind1 = 0; ind1 < nums.Length - 1; ind1++)
            {
                if (ind1 > 0 && nums[ind1] == nums[ind1 - 1])
                {
                    continue;
                }
                var subRes = TwoSum(nums, ind1 + 1, -nums[ind1]);
                if (subRes != null && subRes.Count > 0)
                {
                    subRes.ForEach(sr => sr.Add(nums[ind1]));
                    result.AddRange(subRes);
                }
            }
            for (var ind = 0; ind < result.Count; ++ind)
            {
                result[ind] = result[ind].OrderBy((a) => a).ToList();
            }
            result = result.OrderBy((a) => a[0] * 1.0 + a[1] * 0.0001 + a[2] * 0.0000001).ToList();
            var index = 1;
            while (index < result.Count)
            {
                if (result[index][0] == result[index - 1][0] && result[index][1] == result[index - 1][1] && result[index][2] == result[index - 1][2])
                {
                    result.RemoveAt(index);
                }
                else index++;
            }
            return result;
        }

        public List<IList<int>> TwoSum(int[] nums, int index, int num)
        {
            var left = index;
            var right = nums.Count() - 1;
            var result = new List<IList<int>>();

            while (left < right)
            {
                if (nums[left] + nums[right] == num)
                {
                    result.Add(new List<int>() { nums[left], nums[right] });
                    left += 1;
                    right -= 1;
                }
                else if (nums[left] + nums[right] < num)
                {
                    left += 1;
                }
                else if (nums[left] + nums[right] > num)
                {
                    right -= 1;
                }
            }
            return result;
        }
    }
}
