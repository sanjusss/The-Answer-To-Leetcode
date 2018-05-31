using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0125;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0125.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            string input = "A man, a plan, a canal: Panama";
            bool expected = true;

            Solution solution = new Solution();
            var actual = solution.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPalindromeTest2()
        {
            string input = "race a car";
            bool expected = false;

            Solution solution = new Solution();
            var actual = solution.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPalindromeTest3()
        {
            string input = "";
            bool expected = true;

            Solution solution = new Solution();
            var actual = solution.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }
}