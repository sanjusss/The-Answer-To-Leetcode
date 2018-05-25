using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0107
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
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                int count = nodes.Count;
                List<int> row = new List<int>();
                for (int i = 0; i < count; ++i)
                {
                    TreeNode node = nodes.Dequeue();
                    if (node == null)
                    {
                        continue;
                    }

                    row.Add(node.val);
                    nodes.Enqueue(node.left);
                    nodes.Enqueue(node.right);
                }

                if (row.Count > 0)
                {
                    result.Insert(0, row);
                }
            }

            return result;
        }
    }
}
