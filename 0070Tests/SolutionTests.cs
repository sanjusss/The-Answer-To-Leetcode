using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0070;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0070.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ClimbStairsTest()
        {
            int input = 3;
            int expected = 3;

            Solution solution = new Solution();
            var actual = solution.ClimbStairs(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ClimbStairsTest2()
        {
            int input = 10;
            int expected = 89;

            Solution solution = new Solution();
            var actual = solution.ClimbStairs(input);
            Assert.AreEqual(expected, actual);
        }
    }
}