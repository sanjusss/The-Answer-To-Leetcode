using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0023
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static ListNode CreateList(int[] arr)
        {
            ListNode root = null;
            ListNode head = null;
            foreach (var i in arr)
            {
                if (root == null)
                {
                    root = new ListNode(i);
                    head = root;
                }
                else
                {
                    head.next = new ListNode(i);
                    head = head.next;
                }
            }

            return root;
        }

        static public bool AreEqual(ListNode l1, ListNode l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val)
                {
                    return false;
                }

                l1 = l1.next;
                l2 = l2.next;
            }

            return l1 == null && l2 == null;
        }
    }

    public class Solution
    {
        public class ListNodeCompare : IComparer<ListNode>
        {
            public int Compare(ListNode x, ListNode y)
            {
                return x.val.CompareTo(y.val);
            }
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode root = null;
            ListNode head = null;
            List<ListNode> nodes = new List<ListNode>();
            foreach (var i in lists)
            {
                if (i != null)
                {
                    nodes.Add(i);
                }
            }

            ListNodeCompare compare = new ListNodeCompare();
            nodes.Sort(compare);
            while (nodes.Count > 0)
            {
                ListNode node = nodes[0];
                nodes.RemoveAt(0);
                if (root == null)
                {
                    root = node;
                    head = root;
                }
                else
                {
                    head.next = node;
                    head = node;
                }

                node = node.next;
                if (node != null)
                {
                    int i = nodes.BinarySearch(node, compare);
                    if (i < 0)
                    {
                        i = ~i;
                    }

                    nodes.Insert(i, node);
                }
            }

            return root;
        }
    }
}
