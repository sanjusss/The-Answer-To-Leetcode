using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0019;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0019.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void RemoveNthFromEndTest()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int n = 2;
            int[] expected = { 1, 2, 3, 5 };
            ListNode inputNode = ListNode.CreateList(input);
            ListNode expectedNode = ListNode.CreateList(expected);

            Solution solution = new Solution();
            var actual = solution.RemoveNthFromEnd(inputNode, n);
            if (ListNode.AreEqual(expectedNode, actual) == false)
            {
                Assert.Fail();
            }
        }
    }
}