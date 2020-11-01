using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace leetcodeinterviewquestions.Backtracking
{
    public class WordSearch
    {
        public static int[][] direcions = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
        public bool Exist(char[][] board, string word)
        {
            return FindWord(board, board.Select(b => b.Select(d => false).ToArray()).ToArray(), -1, -1, word);
        }

        public bool FindWord(char[][] board, bool[][] visited, int cx, int cy, string word)
        {
            if (word.Length == 0)
                return true;
            var letter = word[0];
            if (cx == -1)
            {
                for (var x = 0; x < board.Length; ++x)
                    for (var y = 0; y < board[x].Length; ++y)
                    {
                        if (board[x][y] == letter)
                        {
                            visited[x][y] = true;
                            var res = FindWord(board, visited, x, y, word.Substring(1));
                            if (res) return true;
                            visited[x][y] = false;
                        }
                    }
            }
            else
            {
                foreach (var dir in direcions)
                {
                    var newX = cx + dir[0];
                    var newY = cy + dir[1];
                    if (newX >= 0 && newX < board.Length
                        && newY >= 0 && newY < board[0].Length)
                    {
                        if (board[newX][newY] == letter && visited[newX][newY] == false)
                        {
                            visited[newX][newY] = true;
                            var res = FindWord(board, visited, newX, newY, word.Substring(1));
                            if (res) return true;
                            visited[newX][newY] = false;
                        }
                    }
                }
            }
            return false;
        }
    }
}
