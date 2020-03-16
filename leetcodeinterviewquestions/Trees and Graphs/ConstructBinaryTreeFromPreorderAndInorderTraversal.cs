using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodeinterviewquestions.Trees_and_Graphs
{
    public class ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        public TreeNode root;
        public int preIndex = 1;
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0)
                return null;
            var indexInInorder = new int[preorder.Length];
            var inIndex = 0;
            for (var preIndex = 0; preIndex < preorder.Length; ++preIndex)
            {
                for (inIndex = 0; inIndex < inorder.Length; ++inIndex) 
                {
                    if (inorder[inIndex] == preorder[preIndex])
                    {
                        indexInInorder[preIndex] = inIndex;
                        break;
                    }
                }
            }
            root = new TreeNode(preorder[0]);
            var currentNode = root;
            var parentNodes = new Stack<TreeNode>();
            var parentsGoneLeft = new Stack<TreeNode>();
            var foundCurrentNode = false;
            inIndex = 0;
            while (preorder.Length > preIndex && inorder[inIndex] != preorder[preIndex])
            {
                if (currentNode.val == inorder[inIndex])
                {
                    foundCurrentNode = true;
                }
                inIndex++;
            }
            TreeNode highestRightParent = null;
            while (preorder.Length > preIndex)
            {
                if (highestRightParent == null)
                {
                    parentNodes.Push(currentNode);
                    if (!foundCurrentNode)
                    {
                        currentNode.left = new TreeNode(preorder[preIndex]);
                        parentsGoneLeft.Push(currentNode);
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode.right = new TreeNode(preorder[preIndex]);
                        currentNode = currentNode.right;
                    }
                    preIndex += 1;
                    if (preorder.Length > preIndex && indexInInorder[preIndex] < indexInInorder[preIndex - 1])
                    {
                        foundCurrentNode = false;
                    }
                    else
                    {
                        foundCurrentNode = true;
                        highestRightParent = null;
                        inIndex = indexInInorder[preIndex - 1];
                        while (preorder.Length > preIndex && inorder[inIndex] != preorder[preIndex])
                        {
                            foreach (var parent in parentsGoneLeft)
                            {
                                if (parent.val == inorder[inIndex])
                                {
                                    highestRightParent = parent;
                                    break;
                                }
                            }
                            inIndex++;
                        }
                    }
                }
                else
                {
                    if (parentNodes.Peek() == parentsGoneLeft.Peek())
                    {
                        foundCurrentNode = true;
                        parentsGoneLeft.Pop();
                    }
                    else
                    {
                        foundCurrentNode = false;
                    }
                    currentNode = parentNodes.Peek();
                    if (currentNode == highestRightParent)
                    {
                        highestRightParent = null;
                    }
                    parentNodes.Pop();
                }
            }
            return root;
        }
    }
}
