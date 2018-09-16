using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020904
{
    public class Solution
    {
        public int TotalFruit(int[] tree)
        {
            int length = tree.Length;
            int max = 0;
            int firstNumber = -1;
            int firstLength = 0;
            int secondNumber = -1;
            int secondLength = 0;
            int precount = 0;
            for (int i = 0; i < length; ++i)
            {
                if (tree[i] == firstNumber)
                {
                    precount += firstLength;
                    firstNumber = secondNumber;
                    firstLength = secondLength;
                    secondNumber = tree[i];
                    secondLength = 1;
                }
                else if (tree[i] == secondNumber)
                {
                    ++secondLength;
                }
                else
                {
                    max = Math.Max(firstLength + secondLength + precount, max);
                    precount = 0;
                    firstNumber = secondNumber;
                    firstLength = secondLength;
                    secondNumber = tree[i];
                    secondLength = 1;
                }
            }

            max = Math.Max(firstLength + secondLength + precount, max);
            return max;
        }
    }
}
