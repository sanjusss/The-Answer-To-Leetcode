using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0851
{
    public class Solution
    {
        public int[] LoudAndRich(int[][] richer, int[] quiet)
        {
            int N = quiet.Length;
            bool[,] m = CreateM(richer, N);
            List<int> richest = GetRichest(m, N);
            foreach (var i in richest)
            {
                CompleteM(m, N, i);
            }
            
            for (int j = 0; j < N; ++j)
            {
                m[j, j] = true;
            }

            return GetQuiet(m, N, quiet);
        }

        private int[] GetQuiet(bool[,] m, int N, int[] quiet)
        {
            int[] rets = new int[N];

            List<int> quietIndex = new List<int>();
            for (int i = 0; i < N; ++i)
            {
                quietIndex.Add(i);
            }

            quietIndex.Sort((a, b) =>
            {
                if (quiet[a] == quiet[b])
                {
                    return 0;
                }

                return quiet[a] < quiet[b] ? -1 : 1;
            });

            for (int j = 0; j < N; ++j)
            {
                foreach (var i in quietIndex)
                {
                    if (m[i, j])
                    {
                        rets[j] = i;
                        break;
                    }
                }
            }

            return rets;
        }

        bool[,] CreateM(int[][] richer, int N)
        {
            bool[,] m = new bool[N, N];
            for (int i = 0; i < richer.Length; ++i)
            {
                for (int j = 1; j < richer[i].Length; ++j)
                {
                    m[richer[i][0], richer[i][j]] = true;
                }
            }

            return m;
        }

        private HashSet<int> rowComleted = new HashSet<int>();
        void CompleteM(bool[,] m, int N, int index)
        {
            Stack<int> s = new Stack<int>();
            s.Push(index);
            do
            {
                int i = s.Peek();
                bool allComplete = true;
                List<int> poors = new List<int>();
                for (int j = 0; j < N; ++j)
                {
                    if (m[i, j] == false)
                    {
                        continue;
                    }

                    if (rowComleted.Contains(j))
                    {
                        if (allComplete)
                        {
                            poors.Add(j);
                        }
                    }
                    else
                    {
                        s.Push(j);
                        allComplete = false;
                    }
                }

                if (allComplete)
                {
                    foreach (var j in poors)
                    {
                        for (int k = 0; k < N; ++k)
                        {
                            if (m[j, k])
                            {
                                m[i, k] = true;
                            }
                        }
                    }

                    s.Pop();
                    rowComleted.Add(i);
                }
            } while (s.Count > 0);
        }

        List<int> GetRichest(bool[,] m, int N)
        {
            List<int> rets = new List<int>();
            for (int j = 0; j < N; ++j)
            {
                bool success = true;
                for (int i = 0; i < N; ++i)
                {
                    if (m[i, j])
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    rets.Add(j);
                }
            }

            return rets;
        }
    }
}
