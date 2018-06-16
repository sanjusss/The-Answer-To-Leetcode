using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0198;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0198.Tests
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
        public void RobTest()
        {
            int[] nums = ToArray("[1,2,3,1]");
            int expected = 4;

            Solution solution = new Solution();
            var actual = solution.Rob(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RobTest2()
        {
            int[] nums = ToArray("[2,7,9,3,1]");
            int expected = 12;

            Solution solution = new Solution();
            var actual = solution.Rob(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RobTest3()
        {
            int[] nums = ToArray("[0, 0]");
            int expected = 0;

            Solution solution = new Solution();
            var actual = solution.Rob(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}