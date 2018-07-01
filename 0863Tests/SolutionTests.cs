using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0863;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0863.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void DistanceKTest()
        {
            TreeNode root = new TreeNode(0);
            TreeNode head = root;
            head.right = new TreeNode(1);
            head = head.right;
            head.right = new TreeNode(2);
            head = head.right;
            head.right = new TreeNode(3);
            head = head.right;
            head.right = new TreeNode(4);

            TreeNode target = new TreeNode(2);
            int K = 2;
            int[] expected = { 4, 0 };

            Solution solution = new Solution();
            var actual = solution.DistanceK(root, target, K);
            CollectionAssert.AreEquivalent(expected, new List<int>(actual));
        }
    }
}