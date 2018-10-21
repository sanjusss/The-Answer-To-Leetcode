using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1070926;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1070926.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MinFlipsMonoIncrTest()
        {
            string S = "10011111110010111011";
            int expected = 5;

            Solution solution = new Solution();
            int actual = solution.MinFlipsMonoIncr(S);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinFlipsMonoIncrTest2()
        {
            string S = "101010111001010000011101101110";
            int expected = 11;

            Solution solution = new Solution();
            int actual = solution.MinFlipsMonoIncr(S);
            Assert.AreEqual(expected, actual);
        }
    }
}