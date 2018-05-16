using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0038
{
    public class Solution
    {
        public string CountAndSay(int n)
        {
            if (n <= 0)
            {
                return string.Empty;
            }
            else if (n == 1)
            {
                return "1";
            }

            string last = CountAndSay(n - 1);
            string result = string.Empty;
            char current = '\0';
            int count = 0;
            foreach (var i in last)
            {
                if (i == current)
                {
                    ++count;
                }
                else
                {
                    if (count > 0)
                    {
                        result += count.ToString() + current;
                    }

                    current = i;
                    count = 1;
                }
            }

            if (count > 0)
            {
                result += count.ToString() + current;
            }

            return result;
        }
    }
}
