using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1070927
{
    public class Solution
    {
        public int[] ThreeEqualParts(int[] A)
        {
            int[] res = { -1, -1};
            int one = 0;
            foreach (var i in A)
            {
                if (i == 1)
                {
                    ++one;
                }
            }

            if (one % 3 != 0)
            {
                return res;
            }

            int length = A.Length;
            int maxIndex = length - 1;

            if (one == 0)
            {
                if (length >= 3)
                {
                    res[0] = 0;
                    res[1] = 2;
                }

                return res;
            }

            int firstOne = -1;
            int lastOne = -1;
            int firstStart = -1;
            int firstEnd = -1;
            int SecondStart = -1;
            int SecondEnd = -1;

            int firstStartIndex = one / 3 - 1;
            int firstEndIndex = firstStartIndex + 1;
            int SecondStartIndex = (one / 3) * 2 - 1;
            int SecondEndIndex = SecondStartIndex + 1;

            one = 0;
            for (int i = 0; i < length; ++i)
            {
                if (A[i] != 1)
                {
                    continue;
                }

                lastOne = i;
                if (firstOne < 0)
                {
                    firstOne = i;
                }

                if (one == firstStartIndex)
                {
                    firstStart = i;
                }
                else if (one == firstEndIndex)
                {
                    firstEnd = i;
                }

                if (one == SecondStartIndex)
                {
                    SecondStart = i;
                }
                else if (one == SecondEndIndex)
                {
                    SecondEnd = i;
                }

                ++one;
            }

            int zero = maxIndex - lastOne;
            if (AreEqual(A, firstOne, firstStart, firstEnd, SecondStart) &&
                AreEqual(A, firstEnd, SecondStart, SecondEnd, lastOne) &&
                (firstEnd - firstStart - 1) >= zero &&
                (SecondEnd - SecondStart - 1) >= zero)
            {
                res[0] = firstStart + zero;
                res[1] = SecondStart + zero + 1;
            }

            return res;
        }

        private bool AreEqual(int[] A, int aStart, int aEnd, int bStart, int bEnd)
        {
            for (int i = aStart; i <= aEnd; ++i)
            {
                if (A[i] == 0)
                {
                    ++aStart;
                }
                else
                {
                    break;
                }
            }

            for (int i = bStart; i <= bEnd; ++i)
            {
                if (A[i] == 0)
                {
                    ++bStart;
                }
                else
                {
                    break;
                }
            }

            if ((aEnd - aStart) != (bEnd - bStart))
            {
                return false;
            }

            int length = aEnd - aStart;
            for (int i = 0; i <= length; ++i)
            {
                if (A[aStart + i] != A[bStart + i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
