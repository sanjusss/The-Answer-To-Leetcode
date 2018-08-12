using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _970889
{
    public class Solution
    {
        public int[][] SpiralMatrixIII(int R, int C, int r0, int c0)
        {
            int max = R * C;
            int[][] ret = new int[max][];
            int count = 0;
            ret[count++] = new int[2] { r0, c0 };

            int startx = c0 + 1;
            int starty = r0;
            int step = 3;
            while (count < max)
            {
                if (startx >= 0 && startx < C)
                {
                    for (int i = 0; i < step - 1; ++i)
                    {
                        int y = starty + i;
                        if (y >= 0 && y < R)
                        {
                            ret[count++] = new int[2] { y, startx };
                        }
                    }
                }

                starty += (step - 2);

                if (starty >= 0 && starty < R)
                {
                    for (int i = 1; i < step; i++)
                    {
                        int x = startx - i;
                        if (x >= 0 && x < C)
                        {
                            ret[count++] = new int[2] { starty, x };
                        }
                    }
                }

                startx -= (step - 1);

                if (startx >= 0 && startx < C)
                {
                    for (int i = 1; i < step; ++i)
                    {
                        int y = starty - i;
                        if (y >= 0 && y < R)
                        {
                            ret[count++] = new int[2] { y, startx };
                        }
                    }
                }

                starty -= (step - 1);

                if (starty >= 0 && starty < R)
                {
                    for (int i = 1; i < step; i++)
                    {
                        int x = startx + i;
                        if (x >= 0 && x < C)
                        {
                            ret[count++] = new int[2] { starty, x };
                        }
                    }
                }

                startx += step;
                step += 2;
            }

            return ret;
        }
    }
}
