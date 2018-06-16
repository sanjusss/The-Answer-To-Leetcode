using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0122;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0122.Tests
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
        public void MaxProfitTest()
        {
            int[] prices = ToArray("[7,1,5,3,6,4]");
            int expected = 5;

            Solution solution = new Solution();
            var actual = solution.MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxProfitTest2()
        {
            int[] prices = ToArray("[7,6,4,3,1]");
            int expected = 0;

            Solution solution = new Solution();
            var actual = solution.MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }
    }
}