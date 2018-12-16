using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150958
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
        public bool IsCompleteTree(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node.left == null)
                {
                    if (node.right == null)
                    {
                        return CheckQuque(queue);
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (node.right == null)
                {
                    queue.Enqueue(node.left);
                    return CheckQuque(queue);
                }
                else
                {
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }

            return true;
        }

        private bool CheckQuque(Queue<TreeNode> queue)
        {
            foreach (var i in queue)
            {
                if (i.left != null || i.right != null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
