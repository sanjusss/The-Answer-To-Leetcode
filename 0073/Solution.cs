using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0073
{
    public class Solution
    {
        public void SetZeroes(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);
            bool setRow0 = false;
            bool setCol0 = false;

            for (int i = 0; i < colCount; ++i)
            {
                if (matrix[0, i] == 0)
                {
                    setRow0 = true;
                    break;
                }
            }

            for (int i = 0; i < rowCount; ++i)
            {
                if (matrix[i, 0] == 0)
                {
                    setCol0 = true;
                    break;
                }
            }

            for (int i = 1; i < rowCount; ++i)
            {
                for (int j = 1; j < colCount; ++j)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, 0] = 0;
                        matrix[0, j] = 0;
                    }
                }
            }

            for (int i = 1; i < rowCount; ++i)
            {
                if (matrix[i, 0] != 0)
                {
                    continue;
                }

                for (int j = 1; j < colCount; ++j)
                {
                    matrix[i, j] = 0;
                }
            }

            for (int j = 1; j < colCount; ++j)
            {
                if (matrix[0, j] != 0)
                {
                    continue;
                }

                for (int i = 1; i < rowCount; ++i)
                {
                    matrix[i, j] = 0;
                }
            }

            if (setRow0)
            {
                for (int i = 0; i < colCount; ++i)
                {
                    matrix[0, i] = 0;
                }
            }

            if (setCol0)
            {
                for (int i = 0; i < rowCount; ++i)
                {
                    matrix[i, 0] = 0;
                }
            }
        }
    }
}
