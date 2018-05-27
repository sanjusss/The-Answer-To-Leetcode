using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0842;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0842.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        private void AreEqual(IList<int> expected, IList<int> actual)
        {
            if (expected == null && actual == null)
            {
                return;
            }

            if (expected == null || actual == null ||
                expected.Count != actual.Count)
            {
                Assert.Fail();
            }

            int count = expected.Count;
            for (int i = 0; i < count; i++)
            {
                AreEqual(expected, actual);
            }
        }

        [TestMethod()]
        public void SplitIntoFibonacciTest()
        {
            string input = "5511816597";
            List<int> expected = new List<int>();

            Solution solution = new Solution();
            var actual = solution.SplitIntoFibonacci(input);
            AreEqual(expected, actual);
        }
    }
}