using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1130949;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1130949.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void LargestTimeFromDigitsTest()
        {
            int[] A = new int[] { 1, 2, 3, 4 };
            string expected = "23:41";

            Solution solution = new Solution();
            var actual = solution.LargestTimeFromDigits(A);

            Assert.AreEqual(expected, actual);
        }
    }
}