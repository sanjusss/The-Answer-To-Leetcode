using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0848
{
    public class Solution
    {
        private const int zero = 'a' - 1;

        public string ShiftingLetters(string S, int[] shifts)
        {
            int length = Math.Min(S.Length, shifts.Length);

            char[] ret = new char[length];
            int lastShift = 0;
            for (int i = length - 1; i >= 0; --i)
            {
                ret[i] = ShitftingLetter(S[i], shifts[i] + lastShift);
                lastShift += shifts[i];
                lastShift %= 26;
            }

            return new string(ret);
        }

        private char ShitftingLetter(char c, int shift)
        {
            shift = shift % 26;
            int index = c - zero;
            index = (index + shift) % 26;
            if (index == 0)
            {
                index += 26;
            }

            return Convert.ToChar(index + zero);
        }
    }
}
