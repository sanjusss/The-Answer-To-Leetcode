using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0017.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void LetterCombinationsTest()
        {
            string source = "23";
            string[] target = { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

            Solution solution = new Solution();
            List<string> result = solution.LetterCombinations(source) as List<string>;

            CollectionAssert.AreEquivalent(target, result);
        }

        private void Check(string[] target, IList<string> result)
        {
            Assert.AreEqual(target.Length, result.Count);
            HashSet<string> targetSet = new HashSet<string>(target);
            HashSet<string> resultSet = new HashSet<string>(result);
        }
    }
}