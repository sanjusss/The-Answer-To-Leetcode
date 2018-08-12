using Microsoft.VisualStudio.TestTools.UnitTesting;
using _970889;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _970889.Tests
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
        public void SpiralMatrixIIITest()
        {
            int R = 5;
            int C = 6;
            int r0 = 1;
            int c0 = 4;
            int[][] expected = ToArrayArray("[[1,4],[1,5],[2,5],[2,4],[2,3],[1,3],[0,3],[0,4],[0,5],[3,5],[3,4],[3,3],[3,2],[2,2],[1,2],[0,2],[4,5],[4,4],[4,3],[4,2],[4,1],[3,1],[2,1],[1,1],[0,1],[4,0],[3,0],[2,0],[1,0],[0,0]]");

            Solution solution = new Solution();
            var acutal = solution.SpiralMatrixIII(R, C, r0, c0);
            Assert.AreEqual(expected.Length, acutal.Length);
            for (int i = 0; i < expected.Length; ++i)
            {
                CollectionAssert.AreEqual(expected[i], acutal[i]);
            }
        }
    }
}