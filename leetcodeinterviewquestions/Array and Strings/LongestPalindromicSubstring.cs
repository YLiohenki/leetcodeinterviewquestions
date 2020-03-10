using System;
using System.Collections.Generic;
using System.Text;

// https://leetcode.com/explore/interview/card/top-interview-questions-medium/103/array-and-strings/780/

namespace leetcodeinterviewquestions.Array_and_Strings
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 0)
                return "";
            var length = 1;
            var poli = "" + s[0];
            for (var midIndex = 0; midIndex < s.Length; ++midIndex)
            {
                var stillPoli = true;
                for (var sideLen = 1; midIndex + sideLen < s.Length && midIndex - sideLen >= 0 && stillPoli; ++sideLen)
                {
                    if (s[midIndex + sideLen] == s[midIndex - sideLen])
                    {
                        if (length < sideLen * 2 + 1)
                        {
                            length = sideLen * 2 + 1;
                            poli = s.Substring(midIndex - sideLen, length);
                        }
                    }
                    else
                    {
                        stillPoli = false;
                    }
                }

                stillPoli = true;

                for (var sideLen = 0; midIndex + sideLen + 1 < s.Length && midIndex - sideLen >= 0 && stillPoli; ++sideLen)
                {
                    if (s[midIndex + sideLen + 1] == s[midIndex - sideLen])
                    {
                        if (length < sideLen * 2 + 2)
                        {
                            length = sideLen * 2 + 2;
                            poli = s.Substring(midIndex - sideLen, length);
                        }
                    }
                    else
                    {
                        stillPoli = false;
                    }
                }
            }

            return poli;
        }
    }
}
