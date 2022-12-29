using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public  class InsertionBSTIterative
    {
        public class Node 
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int key)
            {
                data = key;
                left = right = null;
            }
        }

        public static Node constructBST(int[] keys) 
        {
            Node root = null;
            foreach (var key in keys)
            {
                root = InsertionIterative(root,key);
            }
            return root;
        }

        public  static Node InsertionIterative(Node root, int key)
        {
            Node curr = root;
            Node parent = null;

            if (root == null)
            {
                return new Node(key);
            }

            while (curr != null)
            {
                parent = curr;

                if (key < curr.data)
                {
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            if (key < parent.data)
            {
                parent.left = new Node(key);
            }
            else
            {
                parent.right = new Node(key);
            }
            return root;
        }

        public static void inorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            inorder(root.left);
            Console.WriteLine(root.data + " ");
            inorder(root.right);
        }
    }
}
