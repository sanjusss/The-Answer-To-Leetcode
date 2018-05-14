using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0028;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0028.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            string haystack = "hello";
            string needle = "ll";
            int expected = 2;

            Solution solution = new Solution();
            int output = solution.StrStr(haystack, needle);
            Assert.AreEqual(expected, output);
        }

        [TestMethod()]
        public void StrStrTest2()
        {
            string haystack = "aaaaa";
            string needle = "bba";
            int expected = -1;

            Solution solution = new Solution();
            int output = solution.StrStr(haystack, needle);
            Assert.AreEqual(expected, output);
        }
    }
}