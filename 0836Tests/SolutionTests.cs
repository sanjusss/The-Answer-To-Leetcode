using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0836;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0836.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void IsRectangleOverlapTest()
        {
            int[] rect1 = { 0, 0, 2, 2 };
            int[] rect2 = { 1, 1, 3, 3 };
            bool expected = true;

            Solution solution = new Solution();
            var actual = solution.IsRectangleOverlap(rect1, rect2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsRectangleOverlapTest2()
        {
            int[] rect1 = { 0, 0, 1, 1 };
            int[] rect2 = { 1, 0, 2, 1 };
            bool expected = false;

            Solution solution = new Solution();
            var actual = solution.IsRectangleOverlap(rect1, rect2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsRectangleOverlapTest3()
        {
            int[] rect1 = { 7, 8, 13, 15 };
            int[] rect2 = { 10, 8, 12, 20 };
            bool expected = true;

            Solution solution = new Solution();
            var actual = solution.IsRectangleOverlap(rect1, rect2);
            Assert.AreEqual(expected, actual);
        }
    }
}