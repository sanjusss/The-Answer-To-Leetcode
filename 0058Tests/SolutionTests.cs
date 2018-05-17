using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0058;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0058.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void LengthOfLastWordTest()
        {
            string input = "Hello World";
            int expected = 5;

            Solution solution = new Solution();
            int actual = solution.LengthOfLastWord(input);
            Assert.AreEqual(expected, actual);
        }
    }
}