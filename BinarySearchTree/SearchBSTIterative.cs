using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BinarySearchTree.InsertionBSTIterative;

namespace BinarySearchTree
{
    public  class SearchBSTIterative
    {
        // Iterative function to search in a given BST
        public static void searchIterative(Node root, int key)
        {
            // start with the root node
            Node curr = root;

            // pointer to store the parent of the current node
            Node parent = null;

            // traverse the tree and search for the key
            while (curr != null && curr.data != key)
            {
                // update the parent to the current node
                parent = curr;

                // if the given key is less than the current node, go to the left subtree;
                // otherwise, go to the right subtree
                if (key < curr.data)
                {
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            // if the key is not present in the key
            if (curr == null)
            {
                Console.WriteLine("Key not found");
                return;
            }

            if (parent == null)
            {
                Console.WriteLine("The node with key " + key + " is root node");
            }
            else if (key < parent.data)
            {
                Console.WriteLine("The given key is the left node of the node with key "
                                + parent.data);
            }
            else
            {
                Console.WriteLine("The given key is the right node of the node with key "
                                + parent.data);
            }
        }

    }
}
