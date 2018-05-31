using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0004;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0004.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            int[] num1 = { 1, 3 };
            int[] num2 = { 2 };
            double expected = 2;

            Solution solution = new Solution();
            var actual = solution.FindMedianSortedArrays(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindMedianSortedArraysTest2()
        {
            int[] num1 = { 1, 2 };
            int[] num2 = { 3, 4 };
            double expected = 2.5;

            Solution solution = new Solution();
            var actual = solution.FindMedianSortedArrays(num1, num2);
            Assert.AreEqual(expected, actual);
        }
    }
}