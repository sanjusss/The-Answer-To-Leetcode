using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0847
{
    public class Solution
    {
        private int[,] path = null;
        private HashSet<int>[,] pass = null;
        private Dictionary<int, int> pathSave = new Dictionary<int, int>();

        public int ShortestPathLength(int[][] graph)
        {
            CreateMinPath(graph);
            HashSet<int> remains = new HashSet<int>();
            for (int i = 0; i < graph.Length; ++i)
            {
                remains.Add(i);
            }

            int minPath = int.MaxValue;
            foreach (var i in remains)
            {
                HashSet<int> nextRemains = new HashSet<int>(remains);
                nextRemains.Remove(i);
                int nextPath = ShortestPathLength(nextRemains, i);
                if (nextPath < minPath)
                {
                    minPath = nextPath;
                }
            }

            return minPath;
        }

        private void CreateMinPath(int[][] graph)
        {
            var newGraph = NormalizeGraph(graph);

            int length = newGraph.Length;
            for (int i = 0; i < length; ++i)
            {
                Queue<KeyValuePair<int, HashSet<int>>> q = new Queue<KeyValuePair<int, HashSet<int>>>();
                foreach (var j in newGraph[i])
                {
                    q.Enqueue(new KeyValuePair<int, HashSet<int>>(j, new HashSet<int>()));
                }

                while (q.Count > 0)
                {
                    int count = q.Count;
                    for (int j = 0; j < count; ++j)
                    {
                        var pair = q.Dequeue();
                        if (path[i, pair.Key] != int.MaxValue)
                        {
                            continue;
                        }

                        path[i, pair.Key] = pair.Value.Count + 1;
                        pass[i, pair.Key] = new HashSet<int>(pair.Value);

                        pair.Value.Add(pair.Key);
                        foreach (var l in newGraph[pair.Key])
                        {
                            if (path[i, l] != int.MaxValue)
                            {
                                continue;
                            }

                            q.Enqueue(new KeyValuePair<int, HashSet<int>>(l, new HashSet<int>(pair.Value)));
                        }
                    }
                }
            }
        }

        private HashSet<int>[] NormalizeGraph(int[][] graph)
        {
            int length = graph.Length;
            var newGraph = new HashSet<int>[length];
            path = new int[length, length];
            pass = new HashSet<int>[length, length];
            for (int i = 0; i < length; ++i)
            {
                newGraph[i] = new HashSet<int>(graph[i]);
            }

            for (int i = 0; i < length; ++i)
            {
                foreach (var j in newGraph[i])
                {
                    if (newGraph[j].Contains(i) == false)
                    {
                        newGraph[j].Add(i);
                    }
                }

                for (int j = 0; j < length; ++j)
                {
                    if (i == j)
                    {
                        path[i, j] = 0;
                    }
                    else
                    {
                        path[i, j] = int.MaxValue;
                    }

                    pass[i, j] = new HashSet<int>();
                }
            }

            return newGraph;
        }

        private int ShortestPathLength(HashSet<int> remains, int src)
        {
            if (remains.Count == 0)
            {
                return 0;
            }

            int minPath = int.MaxValue;
            foreach (var i in remains)
            {
                if (HasIntersected(pass[src, i], remains))
                {
                    continue;
                }

                HashSet<int> nextRemains = new HashSet<int>(remains);
                nextRemains.Remove(i);
                int nextPath = ShortestPathLength(nextRemains, i);
                if (nextPath < minPath - path[src, i])
                {
                    minPath = nextPath + path[src, i];
                }
            }

            return minPath;
        }

        private bool HasIntersected<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
            foreach (var i in a)
            {
                if (b.Contains(i))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
