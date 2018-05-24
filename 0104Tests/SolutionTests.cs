using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0104;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0104.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MaxDepthTest()
        {
            int?[] arr = { 3, 9, 20, null, null, 15, 7 };
            int expected = 3;

            TreeNode tree = TreeNode.CreateNode(arr);
            Solution solution = new Solution();
            var actual = solution.MaxDepth(tree);
            Assert.AreEqual(expected, actual);
        }
    }
}