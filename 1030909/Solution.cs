using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030909
{
    public class Solution
    {
        public int SnakesAndLadders(int[][] board)
        {
            int N = board.Length;
            int[] A = new int[N * N];
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    A[(N - 1 - i) * N + ((i % 2 == 0) ? (N - 1) - j : j)] = board[i][j];
                }
            }
            
            return Run(A, N * N - 1, 0, 0, new HashSet<int>());
        }

        private int Run(int[] A, int end, int index, int last, HashSet<int> passed)
        {
            if (passed.Contains(index))
            {
                return int.MaxValue;
            }
            else
            {
                passed.Add(index);
            }

            int ret = last + 1;
            while (A[index] == -1 && index != end)
            {
                ++index;
            }

            if (index == end)
            {
                return ret;
            }

            int temp = Run(A, end, A[index] - 1, ret, new HashSet<int>(passed));
            do
            {
                ++index;
            } while (A[index] == -1 && index != end) ;

            if (index == end)
            {
                return Math.Min(ret, temp);
            }
            else
            {
                return Math.Min(temp, Run(A, end, index, ret, new HashSet<int>(passed)));
            }
        }
    }
}
