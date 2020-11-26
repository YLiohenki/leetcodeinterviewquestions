using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcodeinterviewquestions.Dynamic
{
    public class CoinChangeSolution
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0)
                return 0;
            var num = new int[amount + 1];
            foreach (var c in coins)
            {
                if (c <= amount)
                {
                    num[c] = 1;
                }
            }
            for (uint i = 1; i < amount; ++i)
            {
                if (num[i] != 0)
                {
                    foreach (var c in coins)
                    {
                        if (i + c <= amount && (num[i + c] == 0 || num[i + c] > num[i] + 1))
                        {
                            num[i + c] = num[i] + 1;
                        }
                    }
                }
            }

            return num[amount] > 0 ? num[amount] : -1;
        }
    }
}
