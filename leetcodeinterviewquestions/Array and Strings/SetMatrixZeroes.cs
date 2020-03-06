using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Array_and_Strings
{
    public class SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
                return;
            var nulifyX0 = false;
            var nulifyY0 = false;
            for (var x = 0; x < matrix.Length; ++x)
            {
                for (var y = 0; y < matrix[0].Length; ++y)
                {
                    if (matrix[x][y] == 0)
                    {
                        if (x != 0)
                            matrix[x][0] = 0;
                        else
                            nulifyY0 = true;
                        if (y != 0)
                            matrix[0][y] = 0;
                        else
                            nulifyX0 = true;
                    }
                }
            }

            for (var x = 1; x < matrix.Length; ++x)
            {
                if (matrix[x][0] == 0)
                    for (var y = 0; y < matrix[0].Length; ++y)
                    {
                        matrix[x][y] = 0;
                    }
            }

            for (var y = 1; y < matrix[0].Length; ++y)
            {
                if (matrix[0][y] == 0)
                    for (var x = 0; x < matrix.Length; ++x)
                    {
                        matrix[x][y] = 0;
                    }
            }

            if (nulifyY0)
            {
                for (var y = 0; y < matrix[0].Length; ++y)
                {
                    matrix[0][y] = 0;
                }
            }
            if (nulifyX0)
            {
                for (var x = 0; x < matrix.Length; ++x)
                {
                    matrix[x][0] = 0;
                }
            }
        }
    }
}
