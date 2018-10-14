using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1060924
{
    public class Solution
    {
        public int MinMalwareSpread(int[][] graph, int[] initial)
        {
            Dictionary<int, List<int>> results = new Dictionary<int, List<int>>();
            int initCount = initial.Length - 1;
            int length = graph.Length;
            foreach (var remove in initial)
            {
                HashSet<int> ti = new HashSet<int>(initial);
                ti.Remove(remove);
                Queue<int> q = new Queue<int>(ti);
                while (q.Count > 0)
                {
                    int i = q.Dequeue();
                    for (int j = 0; j < length; j++)
                    {
                        if (graph[i][j] == 1 &&
                            ti.Contains(j) == false)
                        {
                            ti.Add(j);
                            q.Enqueue(j);
                        }
                    }
                }

                int res = ti.Count;
                if (results.ContainsKey(res) == false)
                {
                    results[res] = new List<int>();
                }

                results[res].Add(remove);
            }

            return results[results.Keys.Min()].Min();
        }
    }
}
