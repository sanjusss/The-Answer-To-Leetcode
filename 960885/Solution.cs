using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _960885
{
    public class Solution
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            int start = 0;
            int end = people.Length - 1;
            int count = 0;
            while (end > start)
            {
                if (people[start] + people[end] > limit)
                {
                    --end;
                }
                else
                {
                    ++start;
                    --end;
                }

                ++count;
            }

            if (start == end)
            {
                ++count;
            }

            return count;
        }
    }
}
