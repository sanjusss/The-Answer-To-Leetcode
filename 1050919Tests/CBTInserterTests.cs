using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1050919;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050919.Tests
{
    [TestClass()]
    public class CBTInserterTests
    {
        [TestMethod()]
        public void Get_rootTest()
        {
            CBTInserter inserter = new CBTInserter(new TreeNode(1));
            Assert.AreEqual(1, inserter.Insert(2));
            var root = inserter.Get_root();
        }
    }
}