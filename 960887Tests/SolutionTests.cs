using Microsoft.VisualStudio.TestTools.UnitTesting;
using _960887;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _960887.Tests
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
        public void ProjectionAreaTest()
        {
            int[][] input = ToArrayArray("[[0,3,4,3],[4,5,0,5],[0,4,2,4],[4,0,0,2]]");
            int expected = 46;

            Solution solution = new Solution();
            var actual = solution.ProjectionArea(input);
            Assert.AreEqual(expected, actual);
        }
    }
}