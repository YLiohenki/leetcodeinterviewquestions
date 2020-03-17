using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Trees_and_Graphs
{
    public class KthSmallestElementInBST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            return KthSmallestRecurs(root, k);
        }

        private int curK = 0;

        public int KthSmallestRecurs(TreeNode current, int k)
        {
            var result = 0;
            if (current.left != null)
                result = KthSmallestRecurs(current.left, k);
            curK += 1;
            if (curK == k)
                return current.val;
            if (current.right != null && curK < k)
                result = KthSmallestRecurs(current.right, k);
            return result;
        }
    }
}
