using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0860
{
    public class Solution
    {
        public bool LemonadeChange(int[] bills)
        {
            int r5 = 0;
            int r10 = 0;
            foreach (var i in bills)
            {
                switch (i)
                {
                    case 5:
                        r5++;
                        break;

                    case 10:
                        if (r5 >= 1)
                        {
                            r5--;
                            r10++;
                            break;
                        }
                        else
                        {
                            return false;
                        }

                    case 20:
                        if (r10 >= 1 && r5 >= 1)
                        {
                            r10--;
                            r5--;
                            break;
                        }
                        else if (r5 >= 3)
                        {
                            r5 -= 3;
                            break;
                        }
                        else
                        {
                            return false;
                        }

                    default:
                        return false;
                }
            }

            return true;
        }
    }
}
