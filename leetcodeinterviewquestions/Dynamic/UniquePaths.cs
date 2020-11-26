using System;
using System.Collections.Generic;

namespace leetcodeinterviewquestions.Dynamic
{
    public class UniquePathsSolution
    {
        public int UniquePaths(int m, int n)
        {
            var stepsMatrix = new int[m,n];
            for (var i = 0; i < Math.Max(m , n); ++i)
            {
                if (i < m) stepsMatrix[i, 0] = 1;
                if (i < n) stepsMatrix[0, i] = 1;
            }

            var x = 1;
            var y = 1;

            while (x < m)
            {
                y = 1;
                while (y < n)
                {
                    stepsMatrix[x, y] = stepsMatrix[x - 1, y] + stepsMatrix[x, y - 1];
                    ++y;
                }
                ++x;
            }
            return stepsMatrix[m-1,n-1];
        }
    }
}
