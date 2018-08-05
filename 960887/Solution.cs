using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _960887
{
    public class Solution
    {
        public int ProjectionArea(int[][] grid)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            int[] zvalues = new int[grid.Length];
            for (int i = 0; i < grid.Length; i++)
            {
                int maxy = 0;
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] <= 0)
                    {
                        continue;
                    }

                    ++x;
                    maxy = Math.Max(grid[i][j], maxy);
                    zvalues[j] = Math.Max(zvalues[j], grid[i][j]);
                }

                y += maxy;
            }

            z = zvalues.Sum();
            return x + y + z;
        }
    }
}
