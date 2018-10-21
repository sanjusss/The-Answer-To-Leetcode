using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1070927;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1070927.Tests
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
        public void ThreeEqualPartsTest()
        {
            int[] A = ToArray("[1,0,1,0,1]");
            int[] expected = ToArray("[0,3]");

            Solution solution = new Solution();
            var actual = solution.ThreeEqualParts(A);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}