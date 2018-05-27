using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0840
{
    public class Solution
    {
        public int NumMagicSquaresInside(int[][] grid)
        {
            int sum = 0;
            int rowCount = grid.Length;
            for (int i = 2; i < rowCount; ++i)
            {
                int colCount = grid[i].Length;
                for (int j = 2; j < colCount; ++j)
                {
                    int[,] test = new int[3,3];
                    bool success = true;
                    for (int k = 0; k < 3; ++k)
                    {
                        for (int l = 0; l < 3; ++l)
                        {
                            test[k, l] = grid[i + k - 2][j + l - 2];
                            if (test[k, l] > 9 || test[k, l] <= 0)
                            {
                                success = false;
                                break;
                            }
                        }

                        if (success == false)
                        {
                            break;
                        }
                    }

                    if (success == false)
                    {
                        continue;
                    }

                    if (IsNumMagicSquares(test))
                    {
                        ++sum;
                    }
                }
            }

            return sum;
        }

        private bool IsNumMagicSquares(int[,] grid)
        {
            int num = GetRowSum(grid, 0);
            for (int i = 1; i < 3; i++)
            {
                if (num != GetRowSum(grid, i))
                {
                    return false;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (num != GetColSum(grid, i))
                {
                    return false;
                }
            }

            if (num != grid[0,0] + grid[1,1] + grid[2,2] ||
                num != grid[0,2] + grid[1,1] + grid[2,0])
            {
                return false;
            }

            return true;
        }

        private int GetRowSum(int[,] grid, int row)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += grid[row,i];
            }

            return sum;
        }

        private int GetColSum(int[,] grid, int col)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += grid[i,col];
            }

            return sum;
        }
    }
}
