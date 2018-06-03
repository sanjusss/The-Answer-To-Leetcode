using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0845
{
    public class Solution
    {
        public int LongestMountain(int[] A)
        {
            int max = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                max = Math.Max(max, GetMountainLength(A, i));
            }

            return max;
        }

        private int GetMountainLength(int[] A, int index)
        {
            if (A[index - 1] >= A[index] ||
                A[index + 1] >= A[index])
            {
                return 0;
            }

            int count = 3;
            int judge = A[index - 1];
            for (int i = index - 2; i >= 0; --i)
            {
                if (A[i] < judge)
                {
                    ++count;
                    judge = A[i];
                }
                else
                {
                    break;
                }
            }

            judge = A[index + 1];
            for (int i = index + 2; i < A.Length; ++i)
            {
                if (A[i] < judge)
                {
                    ++count;
                    judge = A[i];
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
