using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0868
{
    public class Solution
    {
        public int[][] Transpose(int[][] A)
        {
            if (A.Length == 0 ||
                A[0].Length == 0)
            {
                return new int[0][];
            }

            int aRow = A.Length;
            int aCol = A[0].Length;

            int[][] rets = new int[aCol][];
            for (int i = 0; i < aCol; ++i)
            {
                rets[i] = new int[aRow];
                for (int j = 0; j < aRow; ++j)
                {
                    rets[i][j] = A[j][i];
                }
            }

            return rets;
        }
    }
}
