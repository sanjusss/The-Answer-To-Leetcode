using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1100939
{
    public class Solution
    {
        public int MinAreaRect(int[][] points)
        {
            Dictionary<int, HashSet<int>> x2y = new Dictionary<int, HashSet<int>>();
            Dictionary<int, HashSet<int>> y2x = new Dictionary<int, HashSet<int>>();
            foreach (var pt in points)
            {
                if (x2y.ContainsKey(pt[0]) == false)
                {
                    x2y[pt[0]] = new HashSet<int>();
                }

                x2y[pt[0]].Add(pt[1]);

                if (y2x.ContainsKey(pt[1]) == false)
                {
                    y2x[pt[1]] = new HashSet<int>();
                }

                y2x[pt[1]].Add(pt[0]);
            }

            List<int> xs = new List<int>();
            foreach (var i in x2y)
            {
                if (i.Value.Count >= 2)
                {
                    xs.Add(i.Key);
                }
            }

            List<int> ys = new List<int>();
            foreach (var i in y2x)
            {
                if (i.Value.Count >= 2)
                {
                    ys.Add(i.Key);
                }
            }

            int ret = int.MaxValue;
            foreach (var x1 in xs)
            {
                List<int> cys = new List<int>(x2y[x1]);
                int length = cys.Count;
                for (int i = 0; i < length; ++i)
                {
                    int y1 = cys[i];
                    var cx1s = y2x[y1];
                    for (int j = i + 1; j < length; ++j)
                    {
                        int y2 = cys[j];
                        var cx2s = y2x[y2];
                        HashSet<int> cxs = new HashSet<int>(cx1s);
                        cxs.IntersectWith(cx2s);
                        if (cxs.Count <= 1)
                        {
                            continue;
                        }

                        cxs.Remove(x1);
                        int ylength = Math.Abs(y1 - y2);
                        int xlength = int.MaxValue;
                        foreach (var x2 in cxs)
                        {
                            xlength = Math.Min(Math.Abs(x2 - x1), xlength);
                        }

                        ret = Math.Min(xlength * ylength, ret);
                    }
                }
            }

            if (ret == int.MaxValue)
            {
                ret = 0;
            }

            return ret;
        }
    }
}
