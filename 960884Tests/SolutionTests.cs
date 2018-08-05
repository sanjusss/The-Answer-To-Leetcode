using Microsoft.VisualStudio.TestTools.UnitTesting;
using _960884;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _960884.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void DecodeAtIndexTest()
        {
            string input = "leet2code3";
            int K = 10;
            string excepted = "o";

            Solution solution = new Solution();
            var actual = solution.DecodeAtIndex(input, K);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod()]
        public void DecodeAtIndexTest2()
        {
            string input = "a2345678999999999999999";
            int K = 1;
            string excepted = "a";

            Solution solution = new Solution();
            var actual = solution.DecodeAtIndex(input, K);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod()]
        public void DecodeAtIndexTest3()
        {
            string input = "a2b3c4d5e6f7g8h9";
            int K = 3;
            string excepted = "b";

            Solution solution = new Solution();
            var actual = solution.DecodeAtIndex(input, K);
            Assert.AreEqual(excepted, actual);
        }
    }
}