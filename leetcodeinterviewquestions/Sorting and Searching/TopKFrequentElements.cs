using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace leetcodeinterviewquestions.Sorting_and_Searching
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dic.ContainsKey(num))
                {
                    dic.Add(num, 1);
                }
                else dic[num] += 1;
            }

            var arr = dic.Keys.ToList();
            arr.Sort((k1, k2) => { return dic[k2] - dic[k1]; });
            return arr.Take(k).ToArray();
        }
    }
}
