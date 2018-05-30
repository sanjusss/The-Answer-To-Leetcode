using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0019
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
        //public ListNode RemoveNthFromEnd(ListNode head, int n)
        //{
        //    ListNode root = head;
        //    ListNode remove = null;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (head == null)
        //        {
        //            return root;
        //        }

        //        head = head.next;
        //    }

        //    ListNode lastone = null;
        //    remove = root;
        //    while (head != null)
        //    {
        //        head = head.next;
        //        lastone = remove;
        //        remove = remove.next;
        //    }

        //    if (lastone == null)
        //    {
        //        root = root.next;
        //    }
        //    else
        //    {
        //        lastone.next = remove.next;
        //    }

        //    return root;
        //}
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (n <= 0)
            {
                return head;
            }

            ListNode root = head;
            int count = -n;
            while (head != null)
            {
                ++count;
                head = head.next;
            }

            if (count == 0)
            {
                root = root.next;
            }
            else
            {
                head = root;
                --count;
                for (int i = 0; i < count; i++)
                {
                    head = head.next;
                }

                head.next = head.next.next;
            }

            return root;
        }
    }
}
