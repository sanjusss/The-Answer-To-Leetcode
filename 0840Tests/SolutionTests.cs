using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0840;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0840.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void NumMagicSquaresInsideTest()
        {
            int[][] input = new int[3][];
            input[0] = new int[4] { 4, 3, 8, 4 };
            input[1] = new int[4] { 9, 5, 1, 9 };
            input[2] = new int[4] { 2, 7, 6, 2 };
            int expected = 1;

            Solution solution = new Solution();
            var actual = solution.NumMagicSquaresInside(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumMagicSquaresInsideTest2()
        {
            int[][] input = new int[3][];
            //[[10,3,5],[1,6,11],[7,9,2]]
            input[0] = new int[3] { 10, 3, 5 };
            input[1] = new int[3] { 1, 6, 11 };
            input[2] = new int[3] { 7, 9, 2 };
            int expected = 0;

            Solution solution = new Solution();
            var actual = solution.NumMagicSquaresInside(input);
            Assert.AreEqual(expected, actual);
        }
    }
}