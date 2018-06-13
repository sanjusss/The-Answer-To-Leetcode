using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0055;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0055.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        public static int[] ToArray(string input)
        {
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            string[] words = input.Split(',');
            int[] result = new int[words.Length];
            for (int i = 0; i < words.Length; ++i)
            {
                result[i] = Convert.ToInt32(words[i]);
            }

            return result;
        }

        [TestMethod()]
        public void CanJumpTest()
        {
            int[] nums = ToArray("[2,3,1,1,4]");
            bool expected = true;

            Solution solution = new Solution();
            var actual = solution.CanJump(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CanJumpTest2()
        {
            int[] nums = ToArray("[3,2,1,0,4]");
            bool expected = false;

            Solution solution = new Solution();
            var actual = solution.CanJump(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}