using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1090933
{
    public class RecentCounter
    {
        private readonly List<int> _times = new List<int>();

        public RecentCounter()
        {

        }

        public int Ping(int t)
        {
            _times.Add(t);
            int index = _times.BinarySearch(t - 3000);
            if (index < 0)
            {
                index = ~index;
            }

            _times.RemoveRange(0, index - 0);
            return _times.Count;
        }
    }
}
