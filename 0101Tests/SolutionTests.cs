using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0101;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0101.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void IsSymmetricTest()
        {
            int?[] arr = { 1, 2, 2, 3, 4, 4, 3 };
            bool expected = true;

            TreeNode input = TreeNode.CreateNode(arr);
            Solution solution = new Solution();
            var actual = solution.IsSymmetric(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsSymmetricTest2()
        {
            int?[] arr = { 1, 2, 2, null, 3, null, 3 };
            bool expected = false;

            TreeNode input = TreeNode.CreateNode(arr);
            Solution solution = new Solution();
            var actual = solution.IsSymmetric(input);
            Assert.AreEqual(expected, actual);
        }
    }
}