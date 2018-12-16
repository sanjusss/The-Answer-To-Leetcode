using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1150957;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150957.Tests
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
        public void PrisonAfterNDaysTest()
        {
            int[] cells = ToArray("[0,1,0,1,0,1,0,0]");
            int N = 27;
            int[] expected = ToArray("[0,1,0,0,0,1,0,0]");

            Solution solution = new Solution();
            var actual = solution.PrisonAfterNDays(cells, N);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrisonAfterNDaysTest2()
        {
            int[] cells = ToArray("[1, 1, 0, 1, 1, 0, 1, 1]");
            int N = 6;
            int[] expected = ToArray("[0,0,1,0,0,1,0,0]");

            Solution solution = new Solution();
            var actual = solution.PrisonAfterNDays(cells, N);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrisonAfterNDaysTest3()
        {
            int[] cells = ToArray("[1,0,0,1,0,0,1,0]");
            int N = 1000000000;
            int[] expected = ToArray("[0,0,1,1,1,1,1,0]");

            Solution solution = new Solution();
            var actual = solution.PrisonAfterNDays(cells, N);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}