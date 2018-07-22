using Microsoft.VisualStudio.TestTools.UnitTesting;
using _940873;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _940873.Tests
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
        public void LenLongestFibSubseqTest()
        {
            int[] seq = ToArray("[2,4,7,8,9,10,14,15,18,23,32,50]");
            int expected = 5;

            Solution solution = new Solution();
            var actual = solution.LenLongestFibSubseq(seq);
            Assert.AreEqual(expected, actual);
        }
    }
}