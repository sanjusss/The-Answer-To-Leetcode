using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0009;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0009.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            int source = 121;
            bool target = true;

            Solution solution = new Solution();
            var result = solution.IsPalindrome(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void IsPalindromeTest02()
        {
            int source = -121;
            bool target = false;

            Solution solution = new Solution();
            var result = solution.IsPalindrome(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void IsPalindromeTest03()
        {
            int source = 10;
            bool target = false;

            Solution solution = new Solution();
            var result = solution.IsPalindrome(source);
            Assert.AreEqual(target, result);
        }
    }
}