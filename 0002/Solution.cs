using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002
{
    public class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            AddTwoNumbers(l1, l2, result);
            return result;
        }

        private void AddTwoNumbers(ListNode l1, ListNode l2, ListNode result)
        {
            if (l1 == null && l2 == null)
            {
                return;
            }

            ListNode l1Next = null;
            if (l1 != null)
            {
                result.val += l1.val;
                l1Next = l1.next;
            }

            ListNode l2Next = null;
            if (l2 != null)
            {
                result.val += l2.val;
                l2Next = l2.next;
            }

            if (result.val >= 10)
            {
                result.next = new ListNode(result.val / 10);
                result.val = result.val % 10;
            }

            if (l1Next == null && l2Next == null)
            {
                return;
            }

            if (result.next == null)
            {
                result.next = new ListNode(0);
            }

            AddTwoNumbers(l1Next, l2Next, result.next);
        }
    }
}
