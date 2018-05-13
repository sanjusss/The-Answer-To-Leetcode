using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0833;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0833.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindReplaceStringTest()
        {
            string S = "abcd";
            int[] indexes = { 0, 2 };
            string[] sources = { "a", "cd" };
            string[] targets = { "eee", "ffff" };
            string target = "eeebffff";

            Solution solution = new Solution();
            var result = solution.FindReplaceString(S, indexes, sources, targets);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void FindReplaceStringTest2()
        {
            string S = "abcd";
            int[] indexes = { 0, 2 };
            string[] sources = { "ab", "ec" };
            string[] targets = { "eee", "ffff" };
            string target = "eeecd";

            Solution solution = new Solution();
            var result = solution.FindReplaceString(S, indexes, sources, targets);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void FindReplaceStringTest3()
        {
            string S = "vmokgggqzp";
            int[] indexes = { 3, 5, 1 };
            string[] sources = { "kg", "ggq", "mo" };
            string[] targets = { "s", "so", "bfr" };
            string target = "vbfrssozp";

            Solution solution = new Solution();
            var result = solution.FindReplaceString(S, indexes, sources, targets);
            Assert.AreEqual(target, result);
        }
    }
}