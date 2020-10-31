using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Backtracking
{
    public class LetterCombinationsofaPhoneNumber
    {
        public static char[][] letters = new char[][] { new char[] { 'a', 'b', 'c' }, new char[] { 'd', 'e', 'f' }, new char[] { 'g', 'h', 'i' }, new char[] { 'j', 'k', 'l' }, new char[] { 'm', 'n', 'o' }, new char[] { 'p', 'q', 'r', 's' }, new char[] { 't', 'u', 'v' }, new char[] { 'w', 'x', 'y', 'z' } };

        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            getAll(digits, "", result);
            return result;
        }

        protected void getAll(string num, string res, List<string> result)
        {
            if (num.Length > 0)
            {
                var firstDigit = int.Parse(num[0].ToString());
                var variants = letters[firstDigit - 2];
                foreach (var variant in variants)
                {
                    getAll(num.Substring(1), res + variant, result);
                }
            }
            else if (res.Length > 0)
            {
                result.Add(res);
            }
        }
    }
}
