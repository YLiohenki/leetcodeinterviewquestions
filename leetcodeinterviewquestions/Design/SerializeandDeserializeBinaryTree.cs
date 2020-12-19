using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodeinterviewquestions.Design
{
    public class SerializeandDeserializeBinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        // Your Codec object will be instantiated and called as such:
        // Codec ser = new Codec();
        // Codec deser = new Codec();
        // TreeNode ans = deser.deserialize(ser.serialize(root));
        public string serialize(TreeNode root)
        {
            if (root == null)
                return "";
            return root.val.ToString() + "," + (root.left != null ? serialize(root.left) : "-") + "," + (root.right != null ? serialize(root.right) : "-");
        }
        public TreeNode deserialize(string data)
        {
            if (data == "")
                return null;
            var elems = new Queue<string>(data.Split(","));
            return deserializeRecurs(elems);
        }

        public TreeNode deserializeRecurs(Queue<string> elems)
        {
            var result = new TreeNode(int.Parse(elems.Dequeue()));
            var left = elems.Peek();
            if (left != "-")
            {
                result.left = deserializeRecurs(elems);
            }
            else
            {
                elems.Dequeue();
            }
            var right = elems.Peek();
            if (right != "-")
            {
                result.right = deserializeRecurs(elems);
            }
            else
            {
                elems.Dequeue();
            }
            return result;
        }
    }
}
