using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110943
{
    public class Solution
    {
        private int[,] path;

        public string ShortestSuperstring(string[] A)
        {
            if (A.Length == 1)
            {
                return A[0];
            }

            path = new int[A.Length, A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i == j)
                    {
                        path[i, j] = 0;
                    }
                    else
                    {
                        path[i, j] = SameLength(A[i], A[j]);
                    }
                }
            }

            HashSet<int> points = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                points.Add(i);
            }

            List<int> route = Route(points, -1, out int l);
            string res = A[route[0]];
            for (int i = 1; i < route.Count; i++)
            {
                res += A[route[i]].Substring(path[route[i - 1], route[i]]);
            }

            return res;
        }

        private int SameLength(string start, string end)
        {
            int length = Math.Min(start.Length, end.Length) - 1;
            for (int i = length; i >= 1; --i)
            {
                if (start.EndsWith(end.Substring(0, i)))
                {
                    return i;
                }
            }

            return 0;
        }

        private List<int> Route(HashSet<int> remains, int last, out int length)
        {
            length = 0;
            List<int> res = null;
            foreach (var i in remains)
            {
                HashSet<int> tempRemains = new HashSet<int>(remains);
                tempRemains.Remove(i);
                int tempLength = last == -1 ? 0 : path[last, i];
                List<int> tempRes = new List<int>() { i };
                if (tempRemains.Count > 0)
                {
                    tempRes.AddRange(Route(tempRemains, i, out int next));
                    tempLength += next;
                }

                if (tempLength >= length)
                {
                    length = tempLength;
                    res = tempRes;
                }
            }

            return res;
        }
    }
}
