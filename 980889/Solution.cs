using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _980889
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
        public TreeNode ConstructFromPrePost(int[] pre, int[] post)
        {
            return Construct(pre, post, 0, pre.Length - 1, 0, post.Length - 1);
        }

        private TreeNode Construct(int[] pre, int[] post, int preStart, int preEnd, int postStart, int postEnd)
        {
            if (preStart > preEnd)
            {
                return null;
            }

            TreeNode root = new TreeNode(pre[preStart]);
            if (preStart == preEnd)
            {
                return root;
            }

            int preLeft = preStart + 1;
            int leftValue = pre[preLeft];
            int postLeft = postStart;
            while (postLeft <= postEnd)
            {
                if (leftValue == post[postLeft])
                {
                    break;
                }

                ++postLeft;
            }

            int leftLength = postLeft - postStart;
            root.left = Construct(pre, post, preLeft, preLeft + leftLength, postStart, postLeft);
            root.right = Construct(pre, post, preLeft + leftLength + 1, preEnd, postLeft + 1, postEnd - 1);

            return root;
        }
    }
}
