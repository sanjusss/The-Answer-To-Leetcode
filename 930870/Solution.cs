using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _930870
{
    public class Solution
    {

        public int[] AdvantageCount(int[] A, int[] B)
        {
            int length = A.Length;
            Array.Sort(A);
            List<KeyValuePair<int, int>> sortedB = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < length; i++)
            {
                sortedB.Add(new KeyValuePair<int, int>(i, B[i]));
            }

            sortedB.Sort((a, b) =>
            {
                return a.Value.CompareTo(b.Value);
            });

            int[] ret = new int[length];
            int aMax = length - 1;
            int aMin = 0;
            for (int i = length - 1; i >= 0; --i)
            {
                if (A[aMax] > sortedB[i].Value)
                {
                    ret[sortedB[i].Key] = A[aMax];
                    --aMax;
                }
                else
                {
                    ret[sortedB[i].Key] = A[aMin];
                    ++aMin;
                }
            }

            return ret;
        }
    }
}
