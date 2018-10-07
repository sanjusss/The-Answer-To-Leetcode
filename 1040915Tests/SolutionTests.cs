using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1040915;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1040915.Tests
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
        public void PartitionDisjointTest()
        {
            int[] A = ToArray("[5,0,3,8,6]");
            int expected = 3;

            Solution solution = new Solution();
            var actual = solution.PartitionDisjoint(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PartitionDisjointTest2()
        {
            int[] A = ToArray("[1,1,1,0,6,12]");
            int expected = 4;

            Solution solution = new Solution();
            var actual = solution.PartitionDisjoint(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PartitionDisjointTest3()
        {
            int[] A = ToArray("[1,1]");
            int expected = 1;

            Solution solution = new Solution();
            var actual = solution.PartitionDisjoint(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PartitionDisjointTest4()
        {
            int[] A = ToArray("[26,51,40,58,42,76,30,48,79,91]");
            int expected = 1;

            Solution solution = new Solution();
            var actual = solution.PartitionDisjoint(A);
            Assert.AreEqual(expected, actual);
        }
    }
}