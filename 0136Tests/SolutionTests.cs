using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0136;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0136.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void SingleNumberTest()
        {
            int[] input = { 2, 2, 1 };
            int expected = 1;

            Solution solution = new Solution();
            var actual = solution.SingleNumber(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SingleNumberTest2()
        {
            int[] input = { 4, 1, 2, 1, 2 };
            int expected = 4;

            Solution solution = new Solution();
            var actual = solution.SingleNumber(input);
            Assert.AreEqual(expected, actual);
        }
    }
}