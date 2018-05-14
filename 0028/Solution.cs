using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0028
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == null)
            {
                return -1;
            }

            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            
            for (int i = 0; i < haystack.Length - needle.Length + 1; ++i)
            {
                bool success = true;
                for (int j = 0; j < needle.Length; ++j)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
