using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0111;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0111.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MinDepthTest()
        {
            int?[] arr = { 3, 9, 20, null, null, 15, 7 };
            int expected = 2;

            TreeNode tree = TreeNode.CreateNode(arr);
            Solution solution = new Solution();
            var actual = solution.MinDepth(tree);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinDepthTest2()
        {
            int?[] arr = { 1, 2 };
            int expected = 2;

            TreeNode tree = TreeNode.CreateNode(arr);
            Solution solution = new Solution();
            var actual = solution.MinDepth(tree);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinDepthTest3()
        {
            int?[] arr = { 0 };
            int expected = 1;

            TreeNode tree = TreeNode.CreateNode(arr);
            Solution solution = new Solution();
            var actual = solution.MinDepth(tree);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinDepthTest4()
        {
            int?[] arr = { };
            int expected = 0;

            TreeNode tree = TreeNode.CreateNode(arr);
            Solution solution = new Solution();
            var actual = solution.MinDepth(tree);
            Assert.AreEqual(expected, actual);
        }
    }
}