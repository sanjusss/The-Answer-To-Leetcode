using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1040914
{
    public class Solution
    {
        private static int GCD(int m, int n)
        {
            int r, t;
            if (m < n)
            {
                t = n;
                n = m;
                m = t;
            }

            while (n != 0)
            {
                r = m % n;
                m = n;
                n = r;

            }

            return (m);
        }

        public bool HasGroupsSizeX(int[] deck)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            foreach (var i in deck)
            {
                if (values.ContainsKey(i))
                {
                    ++values[i];
                }
                else
                {
                    values[i] = 1;
                }
            }

            List<int> lengths = values.Values.ToList();
            int min = lengths[0];
            for (int i = 1; i < lengths.Count; ++i)
            {
                min = GCD(min, lengths[i]);
                if (min < 2)
                {
                    return false;
                }
            }

            if (min < 2)
            {
                return false;
            }

            return true;
        }
    }
}
