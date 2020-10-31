using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Backtracking
{
    public class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            getAll(n, n, "", result);
            return result;
        }

        protected void getAll(int nO, int nC, string res, List<string> result)
        {
            if (nO > 0)
            {
                getAll(nO - 1, nC, res + "(", result);
            }

            if (nC > 0 && nO < nC)
            {
                getAll(nO, nC - 1, res + ")", result);
            }

            if (nC == 0 && nO == 0 && res.Length > 0)
            {
                result.Add(res);
            }
        }
    }
}
