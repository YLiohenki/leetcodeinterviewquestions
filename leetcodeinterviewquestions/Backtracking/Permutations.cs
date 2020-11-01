using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodeinterviewquestions.Backtracking
{
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            fillPermutations(nums.ToList(), new List<int>(), result);
            return result;
        }

        public void fillPermutations(List<int> nums, List<int> startNums, IList<IList<int>> result)
        {
            if (nums.Count == 0)
            {
                if (startNums.Count > 0)
                {
                    result.Add(startNums.ToList());
                }
                return;
            }
            for (int i = 0; i < nums.Count; ++i)
            {
                startNums.Add(nums[i]);
                nums.RemoveAt(i);
                fillPermutations(nums, startNums, result);
                nums.Insert(i, startNums[startNums.Count - 1]);
                startNums.RemoveAt(startNums.Count - 1);
            }
        }
    }
}
