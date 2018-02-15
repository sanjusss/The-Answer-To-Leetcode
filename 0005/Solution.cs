using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0005
{
    public class Solution
    {
        //public string LongestPalindrome(string s)
        //{
        //    int maxLength = 0;
        //    int length = s.Length;
        //    string result = string.Empty;
        //    for (int i = 0; i < length; ++i)
        //    {
        //        for (int j = length - 1; j >= 0; --j)
        //        {
        //            string sub = s.Substring(i, j - i + 1);
        //            if (IsPalindrome(sub))
        //            {
        //                if (sub.Length > maxLength)
        //                {
        //                    maxLength = sub.Length;
        //                    result = sub;
        //                }

        //                break;
        //            }
        //        }

        //        if (maxLength > length - i - 1)
        //        {
        //            break;
        //        }
        //    }

        //    return result;
        //}

        //private bool IsPalindrome(string s)
        //{
        //    int i = 0;
        //    int j = s.Length - 1;
        //    while (i < j)
        //    {
        //        if (s[i] != s[j])
        //        {
        //            return false;
        //        }

        //        ++i;
        //        --j;
        //    }

        //    return true;
        //}

    }
}
