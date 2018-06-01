using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0168;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0168.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ConvertToTitleTest()
        {
            int input = 1;
            string expected = "A";

            Solution solution = new Solution();
            var actual = solution.ConvertToTitle(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToTitleTest2()
        {
            int input = 28;
            string expected = "AB";

            Solution solution = new Solution();
            var actual = solution.ConvertToTitle(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToTitleTest3()
        {
            int input = 701;
            string expected = "ZY";

            Solution solution = new Solution();
            var actual = solution.ConvertToTitle(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToTitleTest4()
        {
            int input = 52;
            string expected = "AZ";

            Solution solution = new Solution();
            var actual = solution.ConvertToTitle(input);
            Assert.AreEqual(expected, actual);
        }
    }
}