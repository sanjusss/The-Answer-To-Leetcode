using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0125
{
    public class Solution
    {
        //public bool IsPalindrome(string s)
        //{
        //    List<char> remains = new List<char>();
        //    foreach (var c in s)
        //    {
        //        if (char.IsLetterOrDigit(c))
        //        {
        //            remains.Add(char.ToLower(c));
        //        }
        //    }

        //    int maxIndex = remains.Count - 1;
        //    int count = remains.Count / 2;
        //    for (int i = 0; i < count; ++i)
        //    {
        //        if (remains[i] != remains[maxIndex - i])
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char? leftC = null;
            char? rightC = null;
            while (left < right)
            {
                if (leftC == null)
                {
                    if (char.IsLetterOrDigit(s[left]))
                    {
                        leftC = char.ToLower(s[left]);
                        ++left;
                    }
                    else
                    {
                        ++left;
                        continue;
                    }
                }

                if (rightC == null)
                {
                    if (char.IsLetterOrDigit(s[right]))
                    {
                        rightC = char.ToLower(s[right]);
                        --right;
                    }
                    else
                    {
                        --right;
                        continue;
                    }
                }

                if (leftC != rightC)
                {
                    return false;
                }

                leftC = null;
                rightC = null;
            }

            return true;
        }
    }
}
