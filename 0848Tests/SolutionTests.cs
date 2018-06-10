using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0848;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0848.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ShiftingLettersTest()
        {
            string S = "abc";
            int[] shifts = { 3, 5, 9 };
            string expected = "rpl";

            Solution solution = new Solution();
            var actual = solution.ShiftingLetters(S, shifts);
            Assert.AreEqual(expected, actual);
        }

//        "mkgfzkkuxownxvfvxasy"
//[505870226,437526072,266740649,224336793,532917782,311122363,567754492,595798950,81520022,684110326,137742843,275267355,856903962,148291585,919054234,467541837,622939912,116899933,983296461,536563513]
        [TestMethod()]
        public void ShiftingLettersTest2()
        {
            string S = "mkgfzkkuxownxvfvxasy";
            int[] shifts = { 505870226, 437526072, 266740649, 224336793, 532917782, 311122363, 567754492, 595798950, 81520022, 684110326, 137742843, 275267355, 856903962, 148291585, 919054234, 467541837, 622939912, 116899933, 983296461, 536563513 };
            string expected = "wqqwlcjnkphhsyvrkdod";

            Solution solution = new Solution();
            var actual = solution.ShiftingLetters(S, shifts);
            Assert.AreEqual(expected, actual);
        }
    }
}