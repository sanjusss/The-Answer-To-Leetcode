using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0060;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0060.Tests
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
        public void PlusOneTest()
        {
            int[] input = { 1, 2, 3 };
            int[] expected = { 1, 2, 4 };

            Solution solution = new Solution();
            var actual = solution.PlusOne(input);
            AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PlusOneTest2()
        {
            int[] input = { 4, 3, 2, 1 };
            int[] expected = { 4, 3, 2, 2 };

            Solution solution = new Solution();
            var actual = solution.PlusOne(input);
            AreEqual(expected, actual);
        }
    }
}