using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1110943;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110943.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ShortestSuperstringTest()
        {
            string[] A = new string[] { "alex", "loves", "leetcode" };
            string expected = "alexlovesleetcode";

            Solution solution = new Solution();
            var actual = solution.ShortestSuperstring(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShortestSuperstringTest2()
        {
            string[] A = new string[] { "catg", "ctaagt", "gcta", "ttca", "atgcatc" };
            string expected = "gctaagttcatgcatc";

            Solution solution = new Solution();
            var actual = solution.ShortestSuperstring(A);
            Assert.AreEqual(expected, actual);
        }
    }
}