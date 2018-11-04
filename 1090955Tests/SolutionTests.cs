using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1090955;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1090955.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void KnightDialerTest()
        {
            int N = 161;
            int expected = 533302150;

            Solution solution = new Solution();
            var actual = solution.KnightDialer(N);
            Assert.AreEqual(expected, actual);
        }
    }
}