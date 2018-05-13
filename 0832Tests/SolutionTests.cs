using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0832;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0832.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        private void AreEqual(int[][] target, int[][] source)
        {
            Assert.AreEqual(target.Length, source.Length);
            for (int i = 0; i < target.Length; ++i)
            {
                Assert.AreEqual(target[i].Length, source[i].Length);
                for (int j = 0; j < target[i].Length; ++j)
                {
                    Assert.AreEqual(target[i][j], source[i][j]);
                }
            }
        }

        [TestMethod()]
        public void FlipAndInvertImageTest()
        {
            int[][] source = new int[3][];
            source[0] = new int[3] { 1, 1, 0 };
            source[1] = new int[3] { 1, 0, 1 };
            source[2] = new int[3] { 0, 0, 0 };
            int[][] target = new int[3][];
            target[0] = new int[3] { 1, 0, 0 };
            target[1] = new int[3] { 0, 1, 0 };
            target[2] = new int[3] { 1, 1, 1 };

            Solution solution = new Solution();
            var result = solution.FlipAndInvertImage(source);
            AreEqual(target, result);
        }

        [TestMethod()]
        public void FlipAndInvertImageTest2()
        {
            int[][] source = new int[4][];
            source[0] = new int[4] { 1, 1, 0, 0 };
            source[1] = new int[4] { 1, 0, 0, 1 };
            source[2] = new int[4] { 0, 1, 1, 1 };
            source[3] = new int[4] { 1, 0, 1, 0 };
            int[][] target = new int[4][];
            target[0] = new int[4] { 1, 1, 0, 0 };
            target[1] = new int[4] { 0, 1, 1, 0 };
            target[2] = new int[4] { 0, 0, 0, 1 };
            target[3] = new int[4] { 1, 0, 1, 0 };

            Solution solution = new Solution();
            var result = solution.FlipAndInvertImage(source);
            AreEqual(target, result);
        }
    }
}