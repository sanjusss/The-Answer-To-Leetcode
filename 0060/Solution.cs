using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0060
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            List<int> result = new List<int>(digits);
            result[result.Count - 1]++;
            for (int i = result.Count - 1; i >= 0; --i)
            {
                if (result[i] < 10)
                {
                    break;
                }

                result[i] = 0;
                if (i == 0)
                {
                    result.Insert(0, 1);
                }
                else
                {
                    result[i - 1]++;
                }
            }

            return result.ToArray();
        }
    }
}
