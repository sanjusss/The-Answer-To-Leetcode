using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0088;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0088.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        private void AreEqual(int[] expected, int[] actual)
        {
            if (expected == null)
            {
                if (actual != null)
                {
                    Assert.Fail();
                }

                return;
            }

            Assert.AreEqual(expected.Length, actual.Length);
            int count = expected.Length;
            for (int i = 0; i < count; ++i)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod()]
        public void MergeTest()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] expected = { 1, 2, 2, 3, 5, 6 };

            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);
            AreEqual(expected, nums1);
        }
    }
}