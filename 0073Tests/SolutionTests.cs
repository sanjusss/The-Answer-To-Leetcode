using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0073;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0073.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void SetZeroesTest()
        {
            int[,] matrix = To2dArray("[[1,1,1],[1,0,1],[1,1,1]]");
            int[,] expected = To2dArray("[[1,0,1],[0,0,0],[1,0,1]]");

            Solution solution = new Solution();
            solution.SetZeroes(matrix);
            CollectionAssert.AreEqual(expected, matrix);
        }

        public static IList<IList<int>> ToListList(string input)
        {
            input = input.Replace("],[", "#");
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            string[] words = input.Split('#');
            IList<IList<int>> result = new List<IList<int>>();
            foreach (var i in words)
            {
                result.Add(ToList(i));
            }

            return result;
        }

        public static IList<int> ToList(string input)
        {
            return new List<int>(ToArray(input));
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

        public static int[,] To2dArray(string input)
        {
            IList<IList<int>> lists = ToListList(input);
            int rowCount = lists.Count;
            int colCount = lists[0].Count;
            int[,] ret = new int[rowCount, colCount];
            for (int i = 0; i < rowCount; ++i)
            {
                for (int j = 0; j < colCount; ++j)
                {
                    ret[i, j] = lists[i][j];
                }
            }

            return ret;
        }
    }
}