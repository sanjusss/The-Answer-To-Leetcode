using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0026;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0026.Tests
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
        public void RemoveDuplicatesTest()
        {
            int[] source = { 1, 1, 2 };
            int[] target = { 1, 2 };

            Solution solution = new Solution();
            var result = solution.RemoveDuplicates(source);
            AreEqual(source, result, target);
        }

        [TestMethod()]
        public void RemoveDuplicatesTest2()
        {
            int[] source = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] target = { 0, 1, 2, 3, 4 };

            Solution solution = new Solution();
            var result = solution.RemoveDuplicates(source);
            AreEqual(source, result, target);
        }
    }
}