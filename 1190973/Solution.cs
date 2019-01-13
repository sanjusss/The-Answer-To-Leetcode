using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1190973
{
    public class Solution
    {
        public int[][] KClosest(int[][] points, int K)
        {
            List<int[]> list = new List<int[]>(points);
            list.Sort((a, b) => (a[0] * a[0] + a[1] * a[1]).CompareTo(b[0] * b[0] + b[1] * b[1]));
            return list.Take(K).ToArray();
        }
    }
}
