using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Math_Problems
{
    public class FactorialTrailingZeroes
    {
        public int TrailingZeroes(int n)
        {
            var twos = 0;
            var fives = 0;
            var currentTwoMulti = 2;
            while (currentTwoMulti <= n)
            {
                twos += n / currentTwoMulti;
                currentTwoMulti *= 2;
            }
            var currentFivesMulti = 5;
            while (currentFivesMulti <= n)
            {
                fives += n / currentFivesMulti;
                currentFivesMulti *= 5;
            }
            return Math.Min(twos, fives);
        }
    }
}
