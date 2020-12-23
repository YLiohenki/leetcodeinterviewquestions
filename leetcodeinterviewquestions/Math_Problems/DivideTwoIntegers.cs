using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Math_Problems
{
    public class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            var sign = dividend > 0 == divisor > 0 ? true : false;
            uint div = dividend > 0 ? (uint)dividend : (uint)-dividend;
            uint divis = divisor > 0 ? (uint)divisor : (uint)-divisor;
            var result = 0;
            var dic = new Dictionary<int, uint>();
            var multi = 1;
            var currentDivis = divis;
            var overflow = 0;
            while (div >= divis)
            {
                if (currentDivis < div)
                {
                    div -= currentDivis;
                    if (result < 2147483647 - multi)
                        result += multi;
                    else
                    {
                        result = 2147483647;
                        overflow += multi;
                    }
                    currentDivis += divis;
                    multi++;
                }
                else {
                    div -= divis;
                    if (result < 2147483647)
                        result++;
                    else
                    {
                        result = 2147483647;
                        overflow++;
                    }
                }
            }
            return sign ? result : ((overflow == 1) ?-result-1: ((overflow > 1) ? 2147483647 : -result));
        }
    }
}
