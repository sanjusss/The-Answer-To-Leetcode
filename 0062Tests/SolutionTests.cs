using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0062;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0062.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void UniquePathsTest()
        {
            int m = 3;
            int n = 2;
            int expected = 3;

            Solution solution = new Solution();
            var actual = solution.UniquePaths(m, n);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void UniquePathsTest2()
        {
            int m = 7;
            int n = 3;
            int expected = 28;

            Solution solution = new Solution();
            var actual = solution.UniquePaths(m, n);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void UniquePathsTest3()
        {
            int m = 20;
            int n = 20;
            int expected = 985525432;

            Solution solution = new Solution();
            var actual = solution.UniquePaths(m, n);
            Assert.AreEqual(expected, actual);
        }
    }
}