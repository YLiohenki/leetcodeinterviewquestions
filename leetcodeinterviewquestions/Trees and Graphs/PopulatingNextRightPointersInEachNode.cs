﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Trees_and_Graphs
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public class PopulatingNextRightPointersInEachNode
    {
        public Node Connect(Node root)
        {
            if (root != null)
                ConnectRecurs(root, null);
            return root;
        }

        private void ConnectRecurs(Node root, Node toTheRight)
        {
            if (root.left == null)
                return;
            root.left.next = root.right;
            root.right.next = toTheRight?.left;
            ConnectRecurs(root.right, toTheRight?.left);
            ConnectRecurs(root.left, root.right);
        }
    }
}
