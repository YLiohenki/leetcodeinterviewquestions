using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcodeinterviewquestions.Sorting_and_Searching
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            var currentIntervals = 0;
            var sortedStartIntervals = intervals.OrderBy(i => i[0]).Select(i => i[0]).ToArray();
            var sortedEndIntervals = intervals.OrderBy(i => i[1]).Select(i => i[1]).ToArray();
            var currentStart = 0;
            var currentEnd = 0;
            var result = new List<int[]>();
            var resultToAdd = new int[2];
            while (currentStart < sortedStartIntervals.Length)
            {
                if (sortedStartIntervals[currentStart] < sortedEndIntervals[currentEnd])
                {
                    if (currentIntervals == 0)
                    {
                        resultToAdd[0] = sortedStartIntervals[currentStart];
                    }
                    currentIntervals++;
                    currentStart++;
                }
                else if (sortedStartIntervals[currentStart] > sortedEndIntervals[currentEnd])
                {
                    currentIntervals--;
                    if (currentIntervals == 0)
                    {
                        resultToAdd[1] = sortedEndIntervals[currentEnd];
                        result.Add(resultToAdd);
                        resultToAdd = new int[2];
                    }
                    currentEnd++;
                }
                else
                {
                    if (currentIntervals == 0)
                    {
                        resultToAdd[0] = sortedStartIntervals[currentStart];
                        currentStart++;
                        currentIntervals++;
                    }
                    else
                    {
                        currentStart++;
                        currentEnd++;
                    }
                }
            }
            if (intervals.Length > 0)
            {
                resultToAdd[1] = sortedEndIntervals[sortedEndIntervals.Length - 1];
                result.Add(resultToAdd);
            }
            return result.ToArray();
        }
    }
}
