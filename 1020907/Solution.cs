using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020907
{
    public class Solution
    {
        private HashSet<int> passed = new HashSet<int>();

        public int SumSubarrayMins(int[] A)
        {
            ulong sum = 0;
            ulong mod = 1000000007;
            int length = A.Length;
            for (int i = 0; i < length; ++i)
            {
                if (passed.Contains(i))
                {
                    continue;
                }
                else
                {
                    sum += GetMin(A, i, out int r);
                }
            }

            return (int)(sum % mod);
        }

        private ulong GetMin(int[] A, int i, out int r)
        {
            int left = 0;
            int length = A.Length;
            for (int j = i - 1; j >= 0; --j)
            {
                if (A[i] < A[j])
                {
                    ++left;
                }
                else
                {
                    break;
                }
            }

            int right = 0;
            ulong sumc = 0;
            for (int j = i + 1; j < length; ++j)
            {
                if (A[i] < A[j])
                {
                    ++right;
                }
                else if (A[i] == A[j])
                {
                    int rc;
                    sumc = GetMin(A, j, out rc);
                    right += rc + 1;
                    break;
                }
                else
                {
                    break;
                }
            }

            r = right;
            passed.Add(i);
            return sumc + (ulong)A[i] * (ulong)(left + 1) * (ulong)(right + 1);
        }
    }
}
