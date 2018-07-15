using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _930869
{
    public class Solution
    {
        private static readonly List<string> targets = new List<string>();

        static Solution()
        {
            int i = 1;
            do
            {
                var arr = i.ToString().ToCharArray();
                Array.Sort(arr);
                targets.Add(new string(arr));
                i = i << 1;
            } while (i <= 1000000000);
        }

        public bool ReorderedPowerOf2(int N)
        {
            var arr = N.ToString().ToCharArray();
            Array.Sort(arr);
            string source = new string(arr);
            foreach (var i in targets)
            {
                if (i == source)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
