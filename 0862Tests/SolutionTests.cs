using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0862;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0862.Tests
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
        public void ShortestSubarrayTest()
        {
            int[] inpunt = ToArray("[48,99,37,4,-31]");
            int K = 140;
            int expected = 2;

            Solution solution = new Solution();
            var actaul = solution.ShortestSubarray(inpunt, K);
            Assert.AreEqual(expected, actaul);
        }
    }
}