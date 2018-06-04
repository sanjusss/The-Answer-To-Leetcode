using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0023.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MergeKListsTest()
        {
            ListNode[] lists = { null };
            ListNode expected = null;

            Solution solution = new Solution();
            var actual = solution.MergeKLists(lists);
            Assert.IsTrue(ListNode.AreEqual(expected, actual));
        }

        [TestMethod()]
        public void MergeKListsTest2()
        {
            ListNode[] lists = {
                ListNode.CreateList(new int[]{ 1,4,5 }),
                ListNode.CreateList(new int[]{ 1,3,4 }),
                ListNode.CreateList(new int[]{ 2,6 })
            };
            ListNode expected = ListNode.CreateList(new int[] { 1, 1, 2, 3, 4, 4, 5, 6 });

            Solution solution = new Solution();
            var actual = solution.MergeKLists(lists);
            Assert.IsTrue(ListNode.AreEqual(expected, actual));
        }
    }
}