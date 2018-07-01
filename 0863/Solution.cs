using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0863
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
        public class DTreeNode
        {
            public int val;
            public DTreeNode left = null;
            public DTreeNode right = null;
            public DTreeNode parent = null;
            public DTreeNode(int x) { val = x; }
        }

        public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
        {
            DTreeNode tree = FromTreeNode(root);
            DTreeNode start = FindNode(tree, target.val);
            List<int> ret = new List<int>();
            if (start == null)
            {
                return ret;
            }

            if (K == 0)
            {
                ret.Add(target.val);
            }
            else
            {
                ret.AddRange(FindKInChildren(start, K));
                ret.AddRange(FindKInParent(start, K));
            }

            return ret;
        }
        public DTreeNode FromTreeNode(TreeNode root)
        {
            DTreeNode droot = new DTreeNode(root.val);
            if (root.left != null)
            {
                droot.left = FromTreeNode(root.left);
                droot.left.parent = droot;
            }

            if (root.right != null)
            {
                droot.right = FromTreeNode(root.right);
                droot.right.parent = droot;
            }

            return droot;
        }

        public DTreeNode FindNode(DTreeNode node, int target)
        {
            if (node.val == target)
            {
                return node;
            }

            DTreeNode ret = null;
            if (node.left != null)
            {
                ret = FindNode(node.left, target);
            }

            if (ret == null && node.right != null)
            {
                ret = FindNode(node.right, target);
            }

            return ret;
        }

        public List<int> FindKInChildren(DTreeNode node, int K)
        {
            List<int> ret = new List<int>();
            if (node == null)
            {
                return ret;
            }

            if (K == 0)
            {
                ret.Add(node.val);
                return ret;
            }

            ret.AddRange(FindKInChildren(node.left, K - 1));
            ret.AddRange(FindKInChildren(node.right, K - 1));
            return ret;
        }

        public List<int> FindKInParent(DTreeNode node, int K)
        {
            List<int> ret = new List<int>();
            if (K == 0)
            {
                ret.Add(node.val);
                return ret;
            }

            if (node.parent == null)
            {
                return ret;
            }

            DTreeNode child = node.parent.left == node ? node.parent.right : node.parent.left;
            ret.AddRange(FindKInChildren(child, K - 2));
            ret.AddRange(FindKInParent(node.parent, K - 1));
            return ret;
        }
    }
}
