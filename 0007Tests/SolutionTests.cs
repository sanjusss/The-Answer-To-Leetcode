using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0007;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0007.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            int source = -123;
            int target = -321;

            Solution solution = new Solution();
            var result = solution.Reverse(source);
            Assert.AreEqual(target, result);
        }
    }
}