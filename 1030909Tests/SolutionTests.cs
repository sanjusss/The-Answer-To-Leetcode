using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1030909;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030909.Tests
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
        public void SnakesAndLaddersTest()
        {
            int[][] board = ToArrayArray("[[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,35,-1,-1,13,-1],[-1,-1,-1,-1,-1,-1],[-1,15,-1,-1,-1,-1]]");
            int expected = 4;

            Solution solution = new Solution();
            var actual = solution.SnakesAndLadders(board);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SnakesAndLaddersTest2()
        {
            int[][] board = ToArrayArray("[[-1,-1],[-1,3]]");
            int expected = 1;

            Solution solution = new Solution();
            var actual = solution.SnakesAndLadders(board);
            Assert.AreEqual(expected, actual);
        }
    }
}