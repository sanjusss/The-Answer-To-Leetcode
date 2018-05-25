using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0107;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0107.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        private void AreEqual(IList<IList<int>> expected, IList<IList<int>> actual)
        {
            if (expected == null && actual == null)
            {
                return;
            }

            if (expected == null || actual == null)
            {
                Assert.Fail();
            }

            if (expected.Count != actual.Count)
            {
                Assert.Fail();
            }

            int count = expected.Count;
            for (int i = 0; i < count; ++i)
            {
                var rowExpected = expected[i];
                var rowActual = actual[i];
                if (rowExpected.Count != rowActual.Count)
                {
                    Assert.Fail();
                }

                int itemCount = rowExpected.Count;
                for (int j = 0; j < itemCount; ++j)
                {
                    Assert.AreEqual(rowExpected[j], rowActual[j]);
                }
            }
        }

        [TestMethod()]
        public void LevelOrderBottomTest()
        {
            int?[] input = { 3, 9, 20, null, null, 15, 7 };
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new int[] { 15, 7 });
            expected.Add(new int[] { 9, 20 });
            expected.Add(new int[] { 3 });

            var root = TreeNode.CreateNode(input);
            Solution solution = new Solution();
            var actual = solution.LevelOrderBottom(root);
            AreEqual(expected, actual);
        }
    }
}