using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0002;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            Solution.ListNode l1 = new Solution.ListNode(2)
            {
                next = new Solution.ListNode(4)
                {
                    next = new Solution.ListNode(3)
                }
            };
            Solution.ListNode l2 = new Solution.ListNode(5)
            {
                next = new Solution.ListNode(6)
                {
                    next = new Solution.ListNode(4)
                }
            };
            Solution.ListNode target = new Solution.ListNode(7)
            {
                next = new Solution.ListNode(0)
                {
                    next = new Solution.ListNode(8)
                }
            };

            Solution solution = new Solution();
            Solution.ListNode result = solution.AddTwoNumbers(l1, l2);
            AreLinkNodeEqual(target, result);
        }

        private static void AreLinkNodeEqual(Solution.ListNode target, Solution.ListNode result)
        {
            do
            {
                Assert.IsNotNull(result);
                Assert.AreEqual(target.val, result.val);
                target = target.next;
                result = result.next;
            } while (target != null);
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void AddTwoNumbersTest2()
        {
            Solution.ListNode l1 = new Solution.ListNode(1)
            {
                next = new Solution.ListNode(8)
            };
            Solution.ListNode l2 = new Solution.ListNode(0);
            Solution.ListNode target = new Solution.ListNode(1)
            {
                next = new Solution.ListNode(8)
            };

            Solution solution = new Solution();
            Solution.ListNode result = solution.AddTwoNumbers(l1, l2);
            AreLinkNodeEqual(target, result);
        }
    }
}