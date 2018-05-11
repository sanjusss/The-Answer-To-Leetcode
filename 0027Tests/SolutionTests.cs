using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0027;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0027.Tests
{

    [TestClass()]
    public class SolutionTests
    {
        private void AreEqual(int[] result, int count, int[] target)
        {
            Assert.AreEqual(true, count >= target.Length);
            for (int i = 0; i < count; ++i)
            {
                Assert.AreEqual(target[i], result[i]);
            }
        }

        [TestMethod()]
        public void RemoveElementTest()
        {
            int[] source = { 3, 2, 2, 3 };
            int val = 3;
            int[] target = { 2, 2};

            Solution solution = new Solution();
            var result = solution.RemoveElement(source, val);
            AreEqual(source, result, target);
        }

        [TestMethod()]
        public void RemoveElementTest2()
        {
            int[] source = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            int[] target = { 0, 1, 3, 0, 4 };

            Solution solution = new Solution();
            var result = solution.RemoveElement(source, val);
            AreEqual(source, result, target);
        }
    }
}