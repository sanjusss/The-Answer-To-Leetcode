using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0283;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0283.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MoveZeroesTest()
        {
            int[] input = { 0, 1, 0, 3, 12 };
            int[] expected = { 1, 3, 12, 0, 0 };

            Solution solution = new Solution();
            solution.MoveZeroes(input);
            CollectionAssert.AreEqual(expected, input);
        }
    }
}