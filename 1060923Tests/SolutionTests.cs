using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1060923;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1060923.Tests
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
        public void ThreeSumMultiTest()
        {
            int[] A = ToArray("[1,1,2,2,3,3,4,4,5,5]");
            int target = 8;
            int expected = 20;

            Solution solution = new Solution();
            var actual = solution.ThreeSumMulti(A, target);
            Assert.AreEqual(expected, actual);
        }
    }
}