using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110944
{
    public class Solution
    {
        public int MinDeletionSize(string[] A)
        {
            int count = 0;
            int length = A[0].Length;
            for (int i = 0; i < length; i++)
            {
                char last = A[0][i];
                for (int j = 1; j < A.Length; j++)
                {
                    if (A[j][i] < last)
                    {
                        ++count;
                        break;
                    }
                    else
                    {
                        last = A[j][i];
                    }
                }
            }

            return count;
        }
    }
}
