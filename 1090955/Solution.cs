using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1090955
{
    public class Solution
    {
        /// <summary>
        /// 1=3=7=9
        /// 2=8
        /// 4=6
        /// 
        /// 1,2,4,5,0
        /// </summary>
        private static readonly IReadOnlyDictionary<int, int[]> _routes;
        static Solution()
        {
            Dictionary<int, int[]> routes = new Dictionary<int, int[]>();
            routes[1] = new int[] { 2, 4 };
            routes[2] = new int[] { 1, 1 };
            routes[4] = new int[] { 1, 1, 0 };
            routes[0] = new int[] { 4, 4 };
            _routes = routes;
        }

        private const long _mod = 1000000007;
        public int KnightDialer(int N)
        {
            if (N <= 0)
            {
                return 0;
            }
            else if (N == 1)
            {
                return 10;
            }

            Dictionary<int, long> ways = new Dictionary<int, long>();
            ways[0] = 1;
            ways[1] = 4;
            ways[2] = 2;
            ways[4] = 2;

            for (int i = 2; i <= N; ++i)
            {
                Dictionary<int, long> next = new Dictionary<int, long>();
                next[0] = 0;
                next[1] = 0;
                next[2] = 0;
                next[4] = 0;
                foreach (var j in ways)
                {
                    var routes = _routes[j.Key];
                    long value = j.Value;
                    foreach (var k in routes)
                    {
                        next[k] += value;
                        next[k] %= _mod;
                    }
                }

                ways = next;
            }

            long res = 0;
            foreach (var i in ways)
            {
                res += i.Value;
            }

            res = res % _mod;
            return (int)res;
        }
    }
}
