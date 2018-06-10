using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0849
{
    public class Solution
    {
        public int MaxDistToClosest(int[] seats)
        {
            int length = seats.Length;
            int lastMan = -1;
            int maxDist = 0;
            for (int i = 0; i < length; i++)
            {
                if (seats[i] == 1)
                {
                    if (lastMan == -1)
                    {
                        maxDist = i;
                    }
                    else
                    {
                        int dist = (i - lastMan) >> 1;
                        maxDist = Math.Max(dist, maxDist);
                    }

                    lastMan = i;
                }
                else if (i == length - 1)
                {
                    int dist = i - lastMan;
                    maxDist = Math.Max(dist, maxDist);
                }
            }

            return maxDist;
        }
    }
}
