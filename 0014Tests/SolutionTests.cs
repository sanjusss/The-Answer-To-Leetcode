using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0014;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0014.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            string[] strs = { "abcd", "abd", "abc" };
            string target = "ab";

            Solution solution = new Solution();
            string result = solution.LongestCommonPrefix(strs);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void LongestCommonPrefixTest1()
        {
            string[] strs = { "aa", "a" };
            string target = "a";

            Solution solution = new Solution();
            string result = solution.LongestCommonPrefix(strs);
            Assert.AreEqual(target, result);
        }
    }
}