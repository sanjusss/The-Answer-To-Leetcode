using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0021;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0021.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        private void AreEqual(ListNode l1, ListNode l2)
        {
            while (l1 != null && l2 != null)
            {
                Assert.AreEqual(l1.val, l2.val);
                l1 = l1.next;
                l2 = l2.next;
            }

            if (l1 == null && l2 == null)
            {
                return;
            }

            if (l1 == null || l2 == null)
            {
                Assert.Fail();
            }
        }

        private ListNode CreateList(int[] source)
        {
            if (source.Length == 0)
            {
                return null;
            }

            ListNode root = null;
            ListNode head = null;
            foreach (var i in source)
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

        [TestMethod()]
        public void MergeTwoListsTest()
        {
            ListNode l1 = null;
            ListNode l2 = null;
            ListNode target = null;

            Solution solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            Assert.AreEqual(target, result);
        }


        [TestMethod()]
        public void MergeTwoListsTest2()
        {
            int[] al1 = { 1, 2, 4 };
            int[] al2 = { 1, 3, 4 };
            int[] atarget = { 1, 1, 2, 3, 4, 4 };

            ListNode l1 = CreateList(al1);
            ListNode l2 = CreateList(al2);
            ListNode target = CreateList(atarget);

            Solution solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            AreEqual(target, result);
        }
    }
}