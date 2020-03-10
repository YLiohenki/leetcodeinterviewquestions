using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// https://leetcode.com/explore/interview/card/top-interview-questions-medium/103/array-and-strings/778/

namespace leetcodeinterviewquestions.Array_and_Strings
{
    public class GroupAnagram
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0)
                return new List<IList<string>>();
            var sorted = strs.Select(str => new Tuple<string, string>(str, new string(str.ToCharArray().OrderBy(c => c).ToArray()))).OrderBy(tup => tup.Item2).ToArray();
            var result = new List<IList<string>>();
            var currentList = new List<string>();
            currentList.Add(sorted[0].Item1);
            result.Add(currentList);
            for (var index = 1; index < sorted.Count(); ++index)
            {
                if (sorted[index].Item2 == sorted[index - 1].Item2)
                {
                    currentList.Add(sorted[index].Item1);
                }
                else
                {
                    currentList = new List<string>();
                    currentList.Add(sorted[index].Item1);
                    result.Add(currentList);
                }
            }
            return result;
        }
    }
}
