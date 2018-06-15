using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0322;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0322.Tests
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
        public void CoinChangeTest()
        {
            int[] coins = ToArray("[1, 2, 5]");
            int amount = 11;
            int expected = 3;

            Solution solution = new Solution();
            var actual = solution.CoinChange(coins, amount);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CoinChangeTest2()
        {
            int[] coins = ToArray("[2]");
            int amount = 3;
            int expected = -1;

            Solution solution = new Solution();
            var actual = solution.CoinChange(coins, amount);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void CoinChangeTest3()
        {
            int[] coins = ToArray("[186,419,83,408]");
            int amount = 6249;
            int expected = 20;

            Solution solution = new Solution();
            var actual = solution.CoinChange(coins, amount);
            Assert.AreEqual(expected, actual);
        }
    }
}