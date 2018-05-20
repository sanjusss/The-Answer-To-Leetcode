using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0836
{
    public class Solution
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            int x1 = Math.Max(rec1[0], rec2[0]);
            int y1 = Math.Max(rec1[1], rec2[1]);
            int x2 = Math.Min(rec1[2], rec2[2]);
            int y2 = Math.Min(rec1[3], rec2[3]);

            return x1 < x2 && y1 < y2;
        }
    }
}
