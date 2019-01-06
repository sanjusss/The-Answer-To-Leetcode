using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1180970;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1180970.Tests
{
    [TestClass()]
    public class SolutionTests
    {
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

        [TestMethod()]
        public void PowerfulIntegersTest()
        {
            int x = 1;
            int y = 2;
            int bound = 100;
            IList<int> expected = ToList("[33,2,3,5,65,9,17]");

            Solution solution = new Solution();
            var actual = solution.PowerfulIntegers(x, y, bound);
            CollectionAssert.AllItemsAreUnique(new List<int>(actual));
            CollectionAssert.AreEquivalent(new List<int>(expected), new List<int>(actual));
        }
    }
}