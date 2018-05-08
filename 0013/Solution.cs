using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0013
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            int count = s.Length;
            int max = count - 1;
            for (int i = 0; i < count; ++i)
            {
                char c = s[i];
                switch (c)
                {
                    case 'I':
                        if (i < max && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                        {
                            result -= 1;
                        }
                        else
                        {
                            result += 1;
                        }

                        break;

                    case 'V':
                        result += 5;
                        break;

                    case 'X':
                        if (i < max && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                        {
                            result -= 10;
                        }
                        else
                        {
                            result += 10;
                        }

                        break;

                    case 'L':
                        result += 50;
                        break;

                    case 'C':
                        if (i < max && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                        {
                            result -= 100;
                        }
                        else
                        {
                            result += 100;
                        }

                        break;

                    case 'D':
                        result += 500;
                        break;

                    case 'M':
                        result += 1000;
                        break;


                    default:
                        break;
                }
            }

            return result;
        }
    }
}
