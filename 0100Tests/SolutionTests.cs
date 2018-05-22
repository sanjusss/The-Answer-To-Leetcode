using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0100.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void IsSameTreeTest()
        {
            int?[] pArr = { 1, 2, 3 };
            int?[] qArr = { 1, 2, 3 };
            bool expected = true;

            TreeNode p = TreeNode.CreateNode(pArr);
            TreeNode q = TreeNode.CreateNode(qArr);
            Solution solution = new Solution();
            var actual = solution.IsSameTree(p, q);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsSameTreeTest2()
        {
            int?[] pArr = { 1, 2 };
            int?[] qArr = { 1, null, 2 };
            bool expected = false;

            TreeNode p = TreeNode.CreateNode(pArr);
            TreeNode q = TreeNode.CreateNode(qArr);
            Solution solution = new Solution();
            var actual = solution.IsSameTree(p, q);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsSameTreeTest3()
        {
            int?[] pArr = { 1, 2, 1 };
            int?[] qArr = { 1, 1, 2 };
            bool expected = false;

            TreeNode p = TreeNode.CreateNode(pArr);
            TreeNode q = TreeNode.CreateNode(qArr);
            Solution solution = new Solution();
            var actual = solution.IsSameTree(p, q);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsSameTreeTest4()
        {
            int?[] pArr = { 10,5,15 };
            int?[] qArr = { 10, 5, null, null, 15 };
            bool expected = false;

            TreeNode p = TreeNode.CreateNode(pArr);
            TreeNode q = TreeNode.CreateNode(qArr);
            Solution solution = new Solution();
            var actual = solution.IsSameTree(p, q);
            Assert.AreEqual(expected, actual);
        }
    }
}