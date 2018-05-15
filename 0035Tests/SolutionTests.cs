using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0035;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0035.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void SearchInsertTest()
        {
            int[] array = { 1, 3, 5, 6 };
            int des = 5;
            int expected = 2;

            Solution solution = new Solution();
            int actual = solution.SearchInsert(array, des);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchInsertTest2()
        {
            int[] array = { 1, 3, 5, 6 };
            int des = 2;
            int expected = 1;

            Solution solution = new Solution();
            int actual = solution.SearchInsert(array, des);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchInsertTest3()
        {
            int[] array = { 1, 3, 5, 6 };
            int des = 7;
            int expected = 4;

            Solution solution = new Solution();
            int actual = solution.SearchInsert(array, des);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchInsertTest4()
        {
            int[] array = { 1, 3, 5, 6 };
            int des = 0;
            int expected = 0;

            Solution solution = new Solution();
            int actual = solution.SearchInsert(array, des);
            Assert.AreEqual(expected, actual);
        }
    }
}