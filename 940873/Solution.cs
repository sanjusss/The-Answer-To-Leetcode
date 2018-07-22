using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _940873
{
    public class Solution
    {
        public int LenLongestFibSubseq(int[] A)
        {
            int maxLength = 0;
            int length = A.Length;
            for (int i = 0; i < length && length - i > maxLength; ++i)
            {
                for (int j = i + 1; j < length; ++j)
                {
                    int x1 = A[i];
                    int x2 = A[j];
                    int k = Array.BinarySearch<int>(A, j + 1, length - j - 1, x1 + x2);
                    if (k < 0)
                    {
                        continue;
                    }
                    

                    int count = 2;
                    do
                    {
                        ++count;
                        x1 = x2;
                        x2 = A[k];
                        k = Array.BinarySearch<int>(A, k + 1, length - k - 1, x1 + x2);
                    } while (k >= 0);
                    maxLength = Math.Max(maxLength, count);
                }
            }
            
            return maxLength;
        }
    }
}
