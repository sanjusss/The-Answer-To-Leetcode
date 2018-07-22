using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _940872
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
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            return GetLeaives(root1) == GetLeaives(root2);
        }

        public string GetLeaives(TreeNode node)
        {
            if (node == null)
            {
                return string.Empty;
            }

            if (node.left == null && node.right == null)
            {
                return node.val.ToString() + ",";
            }

            return GetLeaives(node.left) + GetLeaives(node.right);
        }
    }
}
