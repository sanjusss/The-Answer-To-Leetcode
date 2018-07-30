using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0008;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0008.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MyAtoiTest()
        {
            string input = "42";
            int expected = 42;

            Solution solution = new Solution();
            var actual = solution.MyAtoi(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MyAtoiTest2()
        {
            string input = "   -42";
            int expected = -42;

            Solution solution = new Solution();
            var actual = solution.MyAtoi(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MyAtoiTest3()
        {
            string input = "4193 with words";
            int expected = 4193;

            Solution solution = new Solution();
            var actual = solution.MyAtoi(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MyAtoiTest4()
        {
            string input = "words and 987";
            int expected = 0;

            Solution solution = new Solution();
            var actual = solution.MyAtoi(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MyAtoiTest5()
        {
            string input = "-91283472332";
            int expected = -2147483648;

            Solution solution = new Solution();
            var actual = solution.MyAtoi(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MyAtoiTest6()
        {
            string input = "+1";
            int expected = 1;

            Solution solution = new Solution();
            var actual = solution.MyAtoi(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MyAtoiTest7()
        {
            string input = "   +0 123";
            int expected = 0;

            Solution solution = new Solution();
            var actual = solution.MyAtoi(input);
            Assert.AreEqual(expected, actual);
        }
    }
}