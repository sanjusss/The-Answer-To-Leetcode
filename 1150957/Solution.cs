using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150957
{
    public class Solution
    {

        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            List<int> vs = new List<int>();
            int v = ToInt(cells);
            while (N > 0)
            {
                vs.Add(v);
                v = Change(v);
                int i = vs.IndexOf(v);
                if (i >= 0)
                {
                    i = ((N - 1) % (vs.Count - i)) + i;

                    v = vs[i];
                    break;
                }

                --N;
            }

            return ToArray(v);
        }

        private int Change(int cells)
        {
            int res = 0;
            for (int i = 1; i <= 6; i++)
            {
                if (((cells & (1 << (i - 1))) > 0) == ((cells & (1 << (i + 1))) > 0))
                {
                    res += (1 << (i));
                }
            }

            return res;
        }


        private int ToInt(int[] cells)
        {
            int res = 0;
            for (int i = 0; i < 8; i++)
            {
                res += (cells[i] << (i));
            }

            return res;
        }

        private int[] ToArray(int cells)
        {
            int[] res = new int[8];
            for (int i = 0; i < 8; i++)
            {
                res[i] = ((cells & (1 << i)) > 0) ? 1 : 0;
            }

            return res;
        }
    }
}
