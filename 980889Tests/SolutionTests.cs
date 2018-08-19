using Microsoft.VisualStudio.TestTools.UnitTesting;
using _980889;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _980889.Tests
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
        public void ConstructFromPrePostTest()
        {
            int[] pre = ToArray("[1,2,4,5,3,6,7]");
            int[] post = ToArray("[4,5,2,6,7,3,1]");

            Solution solution = new Solution();
            var acutal = solution.ConstructFromPrePost(pre, post);
        }

        [TestMethod()]
        public void ConstructFromPrePostTest2()
        {
            int[] pre = ToArray("[1,2]");
            int[] post = ToArray("[2,1]");

            Solution solution = new Solution();
            var acutal = solution.ConstructFromPrePost(pre, post);
        }
    }
}