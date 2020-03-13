using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Trees_and_Graphs
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class BinaryTreeInorderTraversal
    {
        public List<int> result = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return result;
            InorderTraversal(root.left);
            result.Add(root.val);
            InorderTraversal(root.right);
            return result;
        }
    }
}
