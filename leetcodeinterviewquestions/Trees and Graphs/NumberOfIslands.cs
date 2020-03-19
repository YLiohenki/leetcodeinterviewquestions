using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Trees_and_Graphs
{
    public class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            var copy = new int[grid.Length][];
            var index = 0;
            int islands = 0;
            foreach (var row in grid)
            {
                copy[index++] = new int[row.Length];
            }
            for (var x = 0; x < grid.Length; ++x)
            {
                for (var y = 0; y < grid[0].Length; ++y)
                {
                    if (grid[x][y] == '1' && copy[x][y] == 0)
                    {
                        MarkIsland(grid, copy, x, y, ++islands);
                    }
                }
            }
            return islands;
        }
        public void MarkIsland(char[][] grid, int[][] copy, int x, int y, int num)
        {
            if (x < 0 || y < 0 || x >= grid.Length || y >= grid[0].Length || copy[x][y] != 0 || grid[x][y] != '1')
                return;
            copy[x][y] = num;
            MarkIsland(grid, copy, x - 1, y, num);
            MarkIsland(grid, copy, x + 1, y, num);
            MarkIsland(grid, copy, x, y - 1, num);
            MarkIsland(grid, copy, x, y + 1, num);
        }
    }
}
