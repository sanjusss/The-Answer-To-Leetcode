using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0856;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0856.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ScoreOfParenthesesTest()
        {
            string input = "(()(()))";
            int expected = 6;

            Solution solution = new Solution();
            var actual = solution.ScoreOfParentheses(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ScoreOfParenthesesTest2()
        {
            string input = "(()(()))(()(()))";
            int expected = 12;

            Solution solution = new Solution();
            var actual = solution.ScoreOfParentheses(input);
            Assert.AreEqual(expected, actual);
        }
    }
}