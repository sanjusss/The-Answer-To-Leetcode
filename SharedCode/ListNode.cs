using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCode
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
}
