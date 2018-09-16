using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000897
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
        public TreeNode IncreasingBST(TreeNode root)
        {
            List<int> vs = Tree2List(root);
            vs.Sort();

            TreeNode ret = null;
            TreeNode head = null;
            foreach (var i in vs)
            {
                if (ret == null)
                {
                    ret = new TreeNode(i);
                    head = ret;
                }
                else
                {
                    head.right = new TreeNode(i);
                    head = head.right;
                }
            }

            return ret;
        }

        private List<int> Tree2List(TreeNode root)
        {
            List<int> rets = new List<int>();
            if (root != null)
            {
                rets.Add(root.val);
                rets.AddRange(Tree2List(root.left));
                rets.AddRange(Tree2List(root.right));
            }

            return rets;
        }
    }
}
