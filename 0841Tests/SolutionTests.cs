using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0841;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0841.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void CanVisitAllRoomsTest()
        {
            IList<IList<int>> input = new List<IList<int>>();
            input.Add(new List<int>(new int[] { 1 }));
            input.Add(new List<int>(new int[] { 2 }));
            input.Add(new List<int>(new int[] { 3 }));
            input.Add(new List<int>(new int[] {  }));
            bool expected = true;

            Solution solution = new Solution();
            var actual = solution.CanVisitAllRooms(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CanVisitAllRoomsTest2()
        {
            IList<IList<int>> input = new List<IList<int>>();
            input.Add(new List<int>(new int[] { 1, 3 }));
            input.Add(new List<int>(new int[] { 3, 0, 1 }));
            input.Add(new List<int>(new int[] { 2 }));
            input.Add(new List<int>(new int[] { }));
            bool expected = false;

            Solution solution = new Solution();
            var actual = solution.CanVisitAllRooms(input);
            Assert.AreEqual(expected, actual);
        }
    }
}