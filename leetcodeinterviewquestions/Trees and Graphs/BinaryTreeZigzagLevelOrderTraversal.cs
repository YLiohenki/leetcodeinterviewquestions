using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Trees_and_Graphs
{
    public class BinaryTreeZigzagLevelOrderTraversal
    {
        public List<TreeNode> queue = new List<TreeNode>();
        public List<TreeNode> nextQueue = new List<TreeNode>();
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            queue.Add(root);
            var zig = true;
            while (queue.Count > 0)
            {
                var addToResult = new List<int>();
                queue.ForEach(q =>
                {
                    if (q != null)
                    {
                        if (q.left != null)
                            nextQueue.Add(q.left);
                        if (q.right != null)
                            nextQueue.Add(q.right);
                    }
                });
                if (zig)
                {
                    queue.ForEach(q => {
                        addToResult.Add(q.val);
                    });
                }
                else {
                    queue.Reverse();
                    queue.ForEach(q => {
                        addToResult.Add(q.val);
                    });
                }
                zig = !zig;
                result.Add(addToResult);
                queue = nextQueue;
                nextQueue = new List<TreeNode>();
            }

            return result;
        }
    }
}
