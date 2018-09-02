using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _990894
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
        private static Dictionary<int, IList<TreeNode>> trees = new Dictionary<int, IList<TreeNode>>();

        public IList<TreeNode> AllPossibleFBT(int N)
        {
            if (trees.ContainsKey(N))
            {
                return trees[N];
            }

            List<TreeNode> rets = new List<TreeNode>();
            if (N == 1)
            {
                rets.Add(new TreeNode(0));
            }
            else if (N == 2)
            {
                
            }

            trees[N] = rets;
            return rets;
        }
    }
}
