using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0021
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            ListNode root = null;
            ListNode head = null;
            do
            {
                int val;
                if (l1 == null)
                {
                    val = l2.val;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    val = l1.val;
                    l1 = l1.next;
                }
                else if (l1.val <= l2.val)
                {
                    val = l1.val;
                    l1 = l1.next;
                }
                else
                {
                    val = l2.val;
                    l2 = l2.next;
                }

                if (root == null)
                {
                    root = new ListNode(val);
                    head = root;
                }
                else
                {
                    head.next = new ListNode(val);
                    head = head.next;
                }

            } while (l1 != null || l2 != null);

            return root;
        }
    }
}
