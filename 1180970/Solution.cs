using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1180970
{
    public class Solution
    {
        public IList<int> PowerfulIntegers(int x, int y, int bound)
        {
            HashSet<int> res = new HashSet<int>();
            int maxI =  x == 1 ? 0 : (int)Math.Floor(Math.Log(bound, x));
            int maxJ =  y == 1 ? 0 : (int)Math.Floor(Math.Log(bound, y));
            for (int i = 0; i <= maxI; i++)
            {
                for (int j = 0; j <= maxJ; j++)
                {
                    int v = (int)Math.Pow(x, i) + (int)Math.Pow(y, j);
                    if (v <= bound)
                    {
                        res.Add(v);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return res.ToList();
        }
    }
}
