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
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode root = null;
            ListNode head = null;
            List<ListNode> nodes = new List<ListNode>(lists);
            for (int i = nodes.Count - 1; i >= 0; --i)
            {
                if (nodes[i] == null)
                {
                    nodes.RemoveAt(i);
                }
            }

            while (nodes.Count > 0)
            {
                int index = -1;
                int minValue = int.MaxValue;
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i].val < minValue)
                    {
                        index = i;
                        minValue = nodes[i].val;
                    }
                }

                if (root == null)
                {
                    root = new ListNode(nodes[index].val);
                    head = root;
                }
                else
                {
                    head.next = new ListNode(nodes[index].val);
                    head = head.next;
                }

                nodes[index] = nodes[index].next;
                if (nodes[index] == null)
                {
                    nodes.RemoveAt(index);
                }
            }

            return root;
        }
    }
}
