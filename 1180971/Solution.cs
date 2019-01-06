using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1180971
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
        public IList<int> FlipMatchVoyage(TreeNode root, int[] voyage)
        {
            int index = 0;
            var res = FlipMatchVoyage(root, voyage, ref index);
            return res ?? new List<int>() { -1 };
        }

        public List<int> FlipMatchVoyage(TreeNode head, int[] voyage, ref int index)
        {
            List<int> res = new List<int>();
            if (index == voyage.Length - 1)
            {
                return res;
            }

            if (head == null || head.val != voyage[index])
            {
                return null;
            }

            
        }
    }
}
