using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        /// <summary>
        /// Inverts the tree.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <returns></returns>
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            // Swap the left and right children
            TreeNode temp = root.left;

            root.left = root.right;
            root.right = temp;

            // Recursively invert the left and right subtrees
            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }

        /// <summary>
        /// Inorders the traversal.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            InorderHelper(root, result);
            return result;
        }

        private void InorderHelper(TreeNode node, List<int> result)
        {
            if (node == null) return;

            // Traverse left subtree
            InorderHelper(node.left, result);
            // Visit root node
            result.Add(node.val);
            // Traverse right subtree
            InorderHelper(node.right, result);
        }

        /// <summary>
        /// Maximums the depth.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}