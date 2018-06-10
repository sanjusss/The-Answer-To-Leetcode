using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0851;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0851.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        public static int[][] ToArrayArray(string input)
        {
            input = input.Replace("],[", "#");
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            string[] words = input.Split('#');
            int[][] rets = new int[words.Length][];
            for (int i = 0; i < words.Length; ++i)
            {
                rets[i] = ToArray(words[i]);
            }

            return rets;
        }

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
        public void LoudAndRichTest()
        {
            int[][] richer = ToArrayArray("[[1, 0],[2, 1],[3, 1],[3, 7],[4, 3],[5, 3],[6, 3]]");
            int[] quiet = ToArray("[3, 2, 5, 4, 6, 1, 7, 0]");
            int[] expected = ToArray("[5,5,2,5,4,5,6,7]");

            Solution solution = new Solution();
            var actual = solution.LoudAndRich(richer, quiet);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}