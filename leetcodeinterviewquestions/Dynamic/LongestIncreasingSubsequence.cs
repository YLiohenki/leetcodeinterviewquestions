using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcodeinterviewquestions.Dynamic
{
    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            var seqLen = new int[nums.Length];
            for (var i = 0; i < seqLen.Length; ++i)
            {
                seqLen[i] = 1;
            }

            for (var i = 0; i < seqLen.Length; ++i)
            {
                for (var j = i + 1; j < seqLen.Length; ++j)
                {
                    if (nums[i] < nums[j] && seqLen[i] + 1 > seqLen[j])
                    {
                        seqLen[j] = seqLen[i] + 1;
                    }
                }
            }

            return seqLen.Max();
        }
    }
}
