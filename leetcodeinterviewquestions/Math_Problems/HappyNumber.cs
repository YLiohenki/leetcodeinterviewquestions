using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Math_Problems
{
    public class HappyNumber
    {
        Dictionary<int, int> dic;
        public bool IsHappy(int n)
        {
            dic = new Dictionary<int, int>();
            return IsHappyRec(n);
        }

        public bool IsHappyRec(int n)
        {
            if (dic.ContainsKey(n))
                return false;
            if (n == 1)
                return true;
            dic.Add(n, n);
            var next = 0;
            while (n > 0)
            {
                next = next + (n % 10) * (n % 10);
                n /= 10;
            }
            return IsHappyRec(next);
        }
    }
}
