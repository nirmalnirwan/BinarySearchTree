using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public static class InsertionBSTRecursive
    {
        public class Node
        {
            public int data;
            public Node left, right;

            // Function to create a new binary tree node having a given key
            public Node(int key)
            {
                data = key;
                left = right = null;
            }
        }

        // Function to perform inorder traversal on the tree
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

        // Recursive function to insert a key into a BST
        public static Node insert(Node root, int key)
        {
            // if the root is null, create a new node and return it
            if (root == null)
            {
                return new Node(key);
            }

            // if the given key is less than the root node,
            // recur for the left subtree
            if (key < root.data)
            {
                root.left = insert(root.left, key);
            }

            // otherwise, recur for the right subtree
            else
            {
                // key >= root.data
                root.right = insert(root.right, key);
            }

            return root;
        }

        // Function to construct a BST from given keys
        public static Node constructBST(int[] keys)
        {
            Node root = null;

            foreach (var key in keys)
            {
                root = insert(root, key);
            }
            return root;
        }
    }
}
