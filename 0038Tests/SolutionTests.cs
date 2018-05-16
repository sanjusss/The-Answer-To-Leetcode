using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0038;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0038.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void CountAndSayTest()
        {
            int input = 1;
            string expected = "1";

            Solution solution = new Solution();
            var actual = solution.CountAndSay(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountAndSayTest2()
        {
            int input = 4;
            string expected = "1211";

            Solution solution = new Solution();
            var actual = solution.CountAndSay(input);
            Assert.AreEqual(expected, actual);
        }
    }
}