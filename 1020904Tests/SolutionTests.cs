using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1020904;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020904.Tests
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
        public void TotalFruitTest()
        {
            int[] tree = ToArray("[3,3,3,1,2,1,1,2,3,3,4]");
            int expected = 5;

            Solution solution = new Solution();
            int actual = solution.TotalFruit(tree);
            Assert.AreEqual(expected, actual);
        }
    }
}