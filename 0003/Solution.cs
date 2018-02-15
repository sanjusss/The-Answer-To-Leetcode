using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                HashSet<char> sub = new HashSet<char>();
                for (int j = i; j < length; j++)
                {
                    if (sub.Contains(s[j]))
                    {
                        break;
                    }

                    sub.Add(s[j]);
                }

                if (maxLength < sub.Count)
                {
                    maxLength = sub.Count;
                    if (maxLength > length - i - 1)
                    {
                        break;
                    }
                }
            }

            return maxLength;
        }
    }
}
