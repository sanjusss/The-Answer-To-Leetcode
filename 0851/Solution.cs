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
            int[] rets = new int[N];

            HashSet<int>[] poor = new HashSet<int>[N];
            HashSet<int> remains = new HashSet<int>();
            for (int i = 0; i < N; i++)
            {
                poor[i] = new HashSet<int>();
                remains.Add(i);
            }

            for (int i = 0; i < richer.Length; ++i)
            {
                for (int j = 1; j < richer[i].Length; ++j)
                {
                    poor[richer[i][j]].Add(richer[i][0]);
                }
            }

            while (remains.Count > 0)
            {
                int start = remains.First();
            }

            for (int i = 0; i < N; i++)
            {
                rets[i] = i;
                foreach (var j in poor[i])
                {
                    if (quiet[j] < quiet[rets[i]])
                    {
                        rets[i] = j;
                    }
                }
            }

            return rets;
        }
    }
}
