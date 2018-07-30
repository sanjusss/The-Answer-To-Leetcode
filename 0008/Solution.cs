using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0008
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            bool sign = true;
            bool signChecked = false;
            long ret = 0;
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                char c = str[i];
                if (c == '-')
                {
                    if (signChecked)
                    {
                        break;
                    }
                    else
                    {
                        sign = false;
                        signChecked = true;
                    }
                }
                else if (c == '+')
                {
                    if (signChecked)
                    {
                        break;
                    }
                    else
                    {
                        sign = true;
                        signChecked = true;
                    }
                }
                else if (char.IsDigit(c))
                {
                    signChecked = true;
                    ret = ret * 10 + c - '0';
                    if (ret >= UInt32.MaxValue)
                    {
                        break;
                    }
                }
                else if (char.IsWhiteSpace(c) && signChecked == false)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            if (sign)
            {
                if (ret > int.MaxValue)
                {
                    ret = int.MaxValue;
                }
            }
            else
            {
                ret = -ret;
                if (ret < int.MinValue)
                {
                    ret = int.MinValue;
                }
            }

            return (int)ret;
        }
    }
}
