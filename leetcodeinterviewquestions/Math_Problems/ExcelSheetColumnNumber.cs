using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodeinterviewquestions.Math_Problems
{
    public class ExcelSheetColumnNumber
    {
        public int TitleToNumber(string s)
        {
            var letters = s.ToList();
            var result = 0;
            while (letters.Any())
            {
                result = result * 26 + (letters[0] - 'A') + 1;
                letters.RemoveAt(0);
            }
            return result;
        }
    }
}
