using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0334
{
    public class Solution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int a = int.MaxValue;
            int b = int.MaxValue;
            foreach (var i in nums)
            {
                if (a >= i)
                {
                    a = i;
                }
                else if (b >= i)
                {
                    b = i;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
