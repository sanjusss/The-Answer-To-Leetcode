using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0148
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

        public static bool AreEqual(ListNode l1, ListNode l2)
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
        public ListNode SortList(ListNode head)
        {
            if (head == null ||
                head.next == null)
            {
                return head;
            }

            ListNode fast = head;
            ListNode slow = head;
            while (fast.next != null &&
                fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            fast = slow;
            slow = slow.next;
            fast.next = null;
            fast = SortList(head);
            slow = SortList(slow);
            return Merge(fast, slow);
        }

        private ListNode Merge(ListNode a, ListNode b)
        {
            if (a == null)
            {
                return b;
            }

            if (b == null)
            {
                return a;
            }

            ListNode root = null;
            ListNode head = null;
            while (a != null && b != null )
            {
                ListNode temp = null;
                if (a.val < b.val)
                {
                    temp = a;
                    a = a.next;
                }
                else
                {
                    temp = b;
                    b = b.next;
                }

                if (root == null)
                {
                    root = temp;
                    head = root;
                }
                else
                {
                    head.next = temp;
                    head = temp;
                }
            }

            head.next = a ?? b;
            return root;
        }
    }
}
