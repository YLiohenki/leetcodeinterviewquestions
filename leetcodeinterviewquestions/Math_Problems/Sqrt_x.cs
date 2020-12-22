using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Math_Problems
{
    public class Sqrt_x
    {
        public int MySqrt(int x)
        {
            var prev = (x / 2 + 1) * 2;
            var middle = x / 2;
            while (true)
            {
                if (middle < 46341 && middle * middle <= x && ((middle + 1) >= 46341 || (middle + 1) * (middle + 1) > x))
                    return middle;
                if (middle * middle <= x && middle < 46341)
                {
                    middle = middle + Math.Max(1, (prev - middle) / 2);
                }
                else {
                    var m = middle;
                    middle = middle - Math.Max(1 , (prev - middle) / 2);
                    prev = m;
                }
            }
        }
    }
}
