using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodeinterviewquestions.Backtracking
{
    public class SubsetsSolution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            fillPermutations(nums, 0, new List<int>(), result);
            return result;
        }

        public void fillPermutations(int[] nums, int startIndex, List<int> startNums, IList<IList<int>> result)
        {
            result.Add(startNums.ToList());
            for (int i = startIndex; i < nums.Length; ++i)
            {
                startNums.Add(nums[i]);
                fillPermutations(nums, i + 1, startNums, result);
                startNums.RemoveAt(startNums.Count - 1);
            }
        }
    }
}

