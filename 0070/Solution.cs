using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0070
{
    public class Solution
    {
        //static Dictionary<int, int> climbStairs = new Dictionary<int, int>();

        //public int ClimbStairs(int n)
        //{
        //    if (climbStairs.ContainsKey(n) == false)
        //    {
        //        switch (n)
        //        {
        //            case 0:
        //                climbStairs[0] = 0;
        //                break;

        //            case 1:
        //                climbStairs[1] = 1;
        //                break;

        //            case 2:
        //                climbStairs[2] = 2;
        //                break;

        //            default:
        //                climbStairs[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        //                break;
        //        }
        //    }

        //    return climbStairs[n];
        //}

        //private static readonly double sqrt5 = Math.Sqrt(5);
        //public int ClimbStairs(int n)
        //{
        //    ++n;
        //    return (int)((Math.Pow(((1.0 + sqrt5) / 2.0), n) - Math.Pow(((1.0 - sqrt5) / 2.0), n)) / sqrt5 + 0.5);
        //}

        public int ClimbStairs(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }

            int nSub2 = 0;
            int nSub1 = 1;
            int nValue = 2;
            for (int i = 3; i <= n; i++)
            {
                nSub2 = nSub1;
                nSub1 = nValue;
                nValue = nSub2 + nSub1;
            }

            return nValue;
        }
    }
}
