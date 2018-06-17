using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0852;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0852.Tests
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
        public void PeakIndexInMountainArrayTest()
        {
            int[] nums = ToArray("[3,4,5,1]");
            int expected = 2;

            Solution solution = new Solution();
            var actual = solution.PeakIndexInMountainArray(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}