using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0013;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0013.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void RomanToIntTest()
        {
            string source = "III";
            int target = 3;

            Solution solution = new Solution();
            var result = solution.RomanToInt(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void RomanToIntTest2()
        {
            string source = "LVIII";
            int target = 58;

            Solution solution = new Solution();
            var result = solution.RomanToInt(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void RomanToIntTest3()
        {
            string source = "IV";
            int target = 4;

            Solution solution = new Solution();
            var result = solution.RomanToInt(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void RomanToIntTest4()
        {
            string source = "IX";
            int target = 9;

            Solution solution = new Solution();
            var result = solution.RomanToInt(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void RomanToIntTest5()
        {
            string source = "MCMXCIV";
            int target = 1994;

            Solution solution = new Solution();
            var result = solution.RomanToInt(source);
            Assert.AreEqual(target, result);
        }
    }
}