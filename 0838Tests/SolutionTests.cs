using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0838;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0838.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void PushDominoesTest()
        {
            string input = ".L.R...LR..L..";
            string expected = "LL.RR.LLRRLL..";

            Solution solution = new Solution();
            var actual = solution.PushDominoes(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PushDominoesTest2()
        {
            string input = "RR.L";
            string expected = "RR.L";

            Solution solution = new Solution();
            var actual = solution.PushDominoes(input);
            Assert.AreEqual(expected, actual);
        }
    }
}