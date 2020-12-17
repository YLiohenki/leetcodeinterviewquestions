using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Sorting_and_Searching
{
    public class Searcha2DMatrixII
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
                return false;
            var startX = 0;
            var startY = 0;
            var endX = matrix.Length - 1;
            var endY = matrix[0].Length - 1;
            while (endY - startY >= 0 && endX - startX >= 0)
            {
                if (matrix[endX][startY] == target)
                {
                    return true;
                }
                else if (matrix[endX][startY] < target)
                {
                    startY++;
                }
                else
                {
                    endX--;
                }
            }
            return false;
        }
    }
}
