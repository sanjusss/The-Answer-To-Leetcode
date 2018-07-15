using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0867
{
    public class Solution
    {
        public int PrimePalindrome(int N)
        {
            


        }

        private bool IsPrime(int N)
        {
            if (N <= 1 || N % 2 == 0)
            {
                return false;
            }

            int max = (int)Math.Sqrt(N);
            for (int i = 3; i <= max; i += 2)
            {
                if (max % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
