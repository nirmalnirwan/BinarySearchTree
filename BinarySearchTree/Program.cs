using System;

namespace BinarySearchTree
{
    // A class to store a BST node
    
    public class Program
    {
        public static void Main(String[] args)
        {
            int[] keys = { 15, 10, 20, 8, 12, 16, 25 };

            #region InsertionBSTRecursive
            InsertionBSTRecursive.Node root = InsertionBSTRecursive.constructBST(keys);
            InsertionBSTRecursive.inorder(root);
            #endregion


            #region InsertionBSTIterative
            InsertionBSTIterative.Node root1 = InsertionBSTIterative.constructBST(keys);
            InsertionBSTIterative.inorder(root1);
            SearchBSTIterative.searchIterative(root1, 8);

            #endregion
        }
    }
}
