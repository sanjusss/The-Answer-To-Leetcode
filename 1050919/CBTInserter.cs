using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050919
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

    public class CBTInserter
    {
        private List<int> vs = new List<int>();

        public CBTInserter(TreeNode root)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            if (root != null)
            {
                nodes.Add(root);
            }

            while (nodes.Count > 0)
            {
                List<TreeNode> nextNodes = new List<TreeNode>();
                foreach (var i in nodes)
                {
                    vs.Add(i.val);
                    if (i.left != null)
                    {
                        nextNodes.Add(i.left);
                    }

                    if (i.right != null)
                    {
                        nextNodes.Add(i.right);
                    }
                }

                nodes = nextNodes;
            }
        }

        public int Insert(int v)
        {
            vs.Add(v);
            return vs[(vs.Count / 2) - 1];
        }

        public TreeNode Get_root()
        {
            int length = vs.Count;
            TreeNode[] nodes = new TreeNode[length];
            for (int i = 0; i < length; i++)
            {
                nodes[i] = new TreeNode(vs[i]);
                if (i != 0)
                {
                    int parent = (i - 1) / 2;
                    if (i % 2 == 0)
                    {
                        nodes[parent].right = nodes[i];
                    }
                    else
                    {
                        nodes[parent].left = nodes[i];
                    }
                }
            }

            return nodes[0];
        }
    }
}
