using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1100938
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
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.val < L)
            {
                return RangeSumBST(root.right, L, R);
            }

            if (root.val > R)
            {
                return RangeSumBST(root.left, L, R);
            }

            return root.val +
                RangeSumBST(root.left, L, R) +
                RangeSumBST(root.right, L, R);
        }
    }
}
