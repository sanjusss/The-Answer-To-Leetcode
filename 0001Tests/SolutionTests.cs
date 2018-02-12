using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0001.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            Solution solution = new Solution();

            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] result1 = { 0, 1 };
            CollectionAssert.AreEqual(result1, solution.TwoSum(nums1, target1));

            int[] nums2 = { 3, 2, 4 };
            int target2 = 6;
            int[] result2 = { 1, 2 };
            CollectionAssert.AreEqual(result2, solution.TwoSum(nums2, target2));
        }
    }
}