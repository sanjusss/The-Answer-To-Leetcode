using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0020;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0020.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            string source = "()";
            bool target = true;

            Solution solution = new Solution();
            var result = solution.IsValid(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void IsValidTest2()
        {
            string source = "()";
            bool target = true;

            Solution solution = new Solution();
            var result = solution.IsValid(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void IsValidTest3()
        {
            string source = "()[]{}";
            bool target = true;

            Solution solution = new Solution();
            var result = solution.IsValid(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void IsValidTest4()
        {
            string source = "(]";
            bool target = false;

            Solution solution = new Solution();
            var result = solution.IsValid(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void IsValidTest5()
        {
            string source = "{[]}";
            bool target = true;

            Solution solution = new Solution();
            var result = solution.IsValid(source);
            Assert.AreEqual(target, result);
        }
    }
}