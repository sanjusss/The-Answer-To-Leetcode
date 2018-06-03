using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0844
{
    public class Solution
    {
        public bool BackspaceCompare(string S, string T)
        {
            return RemoveBacksapce(S) == RemoveBacksapce(T);
        }

        private string RemoveBacksapce(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in s)
            {
                if (c == '#')
                {
                    if (sb.Length > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
