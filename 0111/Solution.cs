using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0111
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
        static public TreeNode CreateNode(int?[] arr)
        {
            return CreateNode(arr, 0);
        }

        static private TreeNode CreateNode(int?[] arr, int index)
        {
            TreeNode that = arr[index] == null ? null : new TreeNode(arr[index].Value);
            if (that != null && index * 2 + 1 < arr.Length)
            {
                that.left = CreateNode(arr, index * 2 + 1);
                if (index * 2 + 2 < arr.Length)
                {
                    that.right = CreateNode(arr, index * 2 + 2);
                }
            }

            return that;
        }
    }

    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return MinDepthCalc(root);
            }
        }

        private int MinDepthCalc(TreeNode root)
        {
            if (root == null)
            {
                return int.MaxValue;
            }
            else if (root.left == null && root.right == null)
            {
                return 1;
            }

            return 1 + Math.Min(MinDepthCalc(root.left),
                MinDepthCalc(root.right));
        }
    }
}
