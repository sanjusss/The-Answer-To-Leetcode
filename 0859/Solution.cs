using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0859
{
    public class Solution
    {
        public bool BuddyStrings(string A, string B)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            int length = A.Length;
            int diff = 0;
            char a = '0';
            char b = '0';
            HashSet<char> chars = new HashSet<char>();
            for (int i = 0; i < length; i++)
            {
                if (A[i] == B[i])
                {
                    chars.Add(A[i]);
                    continue;
                }

                ++diff;
                switch (diff)
                {
                    case 1:
                        a = A[i];
                        b = B[i];
                        break;

                    case 2:
                        if (A[i] != b ||
                            a != B[i])
                        {
                            return false;
                        }

                        break;

                    default:
                        return false;
                }
            }

            if (diff == 0)
            {
                return chars.Count != length;
            }

            return diff == 2;
        }
    }
}
