using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _970980
{
    public class Solution
    {
        public bool PossibleBipartition(int N, int[][] dislikes)
        {
            HashSet<int> ga = new HashSet<int>();
            for (int i = 1; i <= N; i++)
            {
                ga.Add(i);
            }
            HashSet<int> gb = new HashSet<int>();
            HashSet<int> gbdiss = new HashSet<int>();


            foreach (var i in dislikes)
            {
                int a = i[0];
                int b = i[1];

                if (gb.Contains(a) && gb.Contains(b))
                {
                    return false;
                }
                else if (ga.Contains(a) && gb.Contains(b))
                {
                    gbdiss.Add(a);
                }
                else if (gb.Contains(a) && ga.Contains(b))
                {
                    gbdiss.Add(b);
                }
                else if (ga.Contains(a) && ga.Contains(b))
                {
                    if (gbdiss.Contains(a) == false)
                    {
                        ga.Remove(a);
                        gb.Add(a);
                        gbdiss.Add(b);
                    }
                    else if (gbdiss.Contains(b) == false)
                    {
                        ga.Remove(b);
                        gb.Add(b);
                        gbdiss.Add(a);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
