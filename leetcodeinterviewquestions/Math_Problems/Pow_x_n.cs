using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Math_Problems
{
    public class Pow_x_n
    {
        public double MyPow(double x, int n)
        {
            if (n == 0 || x == 1)
                return 1;
            x = n > 0 ? x : 1 / x;
            UInt64 p = n > 0 ? (UInt64)n : (UInt64)(-(n + 100)) + 100;
            var result = x;
            Dictionary<UInt64, double> pows = new Dictionary<UInt64, double>();
            uint currentPower = 1;
            while (currentPower <= p - 1)
            {
                pows.Add(currentPower, result);
                result *= result;
                currentPower *= 2;
            }
            result = x;
            while (p > 1)
            {
                if (p > currentPower)
                {
                    result *= pows[currentPower];
                    p -= currentPower;
                }
                currentPower /= 2;
            }
            return result;
        }
    }
}
