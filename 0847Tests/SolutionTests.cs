using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0847;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0847.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ShortestPathLengthTest()
        {
            int[][] graph = new int[4][];
            graph[0] = new int[]{ 1, 2, 3 };
            graph[1] = new int[] { 0 };
            graph[2] = new int[] { 0 };
            graph[3] = new int[] { 0 };
            int expected = 4;

            Solution solution = new Solution();
            var actual = solution.ShortestPathLength(graph);
            Assert.AreEqual(expected, actual);
        }

        //[[1],[0,2,4],[1,3,4],[2],[1,2]]
        [TestMethod()]
        public void ShortestPathLengthTest2()
        {
            int[][] graph = new int[5][];
            graph[0] = new int[] { 1 };
            graph[1] = new int[] { 0, 2, 4 };
            graph[2] = new int[] { 1, 3, 4 };
            graph[3] = new int[] { 2 };
            graph[4] = new int[] { 1, 2 };
            int expected = 4;

            Solution solution = new Solution();
            var actual = solution.ShortestPathLength(graph);
            Assert.AreEqual(expected, actual);
        }

        //[[1],[0,2],[1,3],[2],[1,5],[4]]
        [TestMethod()]
        public void ShortestPathLengthTest3()
        {
            int[][] graph = new int[6][];
            graph[0] = new int[] { 1 };
            graph[1] = new int[] { 0, 2 };
            graph[2] = new int[] { 1, 3 };
            graph[3] = new int[] { 2 };
            graph[4] = new int[] { 1, 5 };
            graph[5] = new int[] { 4 };
            int expected = 6;

            Solution solution = new Solution();
            var actual = solution.ShortestPathLength(graph);
            Assert.AreEqual(expected, actual);
        }

        //[[2,3],[7],[0,6],[0,4,7],[3,8],[7],[2],[5,3,1],[4]]
        [TestMethod()]
        public void ShortestPathLengthTest4()
        {
            int[][] graph = new int[9][];
            graph[0] = new int[] { 2, 3 };
            graph[1] = new int[] { 7 };
            graph[2] = new int[] { 0, 6 };
            graph[3] = new int[] { 0, 4, 7 };
            graph[4] = new int[] { 3, 8 };
            graph[5] = new int[] { 7 };
            graph[6] = new int[] { 2 };
            graph[7] = new int[] { 5, 3, 1 };
            graph[8] = new int[] { 4 };
            int expected = 11;

            Solution solution = new Solution();
            var actual = solution.ShortestPathLength(graph);
            Assert.AreEqual(expected, actual);
        }

        //[[1,4],[0,3,10],[3],[1,2,6,7],[0,5],[4],[3],[3],[10],[10],[1,9,8]]
        [TestMethod()]
        public void ShortestPathLengthTest5()
        {
            int[][] graph = new int[11][];
            graph[0] = new int[] { 1, 4 };
            graph[1] = new int[] { 0, 3, 10 };
            graph[2] = new int[] { 3 };
            graph[3] = new int[] { 1, 2, 6, 7 };
            graph[4] = new int[] { 0, 5 };
            graph[5] = new int[] { 4 };
            graph[6] = new int[] { 3 };
            graph[7] = new int[] { 3 };
            graph[8] = new int[] { 10 };
            graph[9] = new int[] { 10 };
            graph[10] = new int[] { 1, 9, 8 };
            int expected = 15;

            Solution solution = new Solution();
            var actual = solution.ShortestPathLength(graph);
            Assert.AreEqual(expected, actual);
        }
    }
}