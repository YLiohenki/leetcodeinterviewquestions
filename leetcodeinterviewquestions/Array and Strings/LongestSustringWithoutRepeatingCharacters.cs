using System;
using System.Collections.Generic;
using System.Text;

// https://leetcode.com/explore/interview/card/top-interview-questions-medium/103/array-and-strings/779/

namespace leetcodeinterviewquestions.Array_and_Strings
{
    public class LongestSustringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
                return 0;
            var length = 1;
            var encountered = new List<char>();
            var startIndex = 0;
            encountered.Add(s[0]);
            for (var index = 1; index < s.Length; ++index)
            {
                if (encountered.Contains(s[index]))
                {
                    while (s[startIndex] != s[index])
                    {
                        if (encountered.Contains(s[startIndex]))
                            encountered.Remove(s[startIndex]);
                        startIndex++;
                    }
                    startIndex++;
                }
                else {
                    encountered.Add(s[index]);
                    if (length < index - startIndex + 1)
                    {
                        length = index - startIndex + 1;
                    }
                }
            }

            return length;
        }
    }
}
