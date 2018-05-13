using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0832
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int[][] result = new int[A.Length][];
            int rowCount = A.Length;
            for (int i = 0; i < rowCount; ++i)
            {
                int colCount = A[i].Length;
                result[i] = new int[colCount];
                for (int j = 0; j < colCount; ++j)
                {
                    result[i][colCount - 1 - j] = A[i][j] == 0 ? 1 : 0;
                }
            }

            return result;
        }
    }
}
