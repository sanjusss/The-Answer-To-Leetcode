using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0020
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            try
            {
                Stack<char> items = new Stack<char>();
                foreach (var i in s)
                {
                    switch (i)
                    {
                        case '(':
                        case '[':
                        case '{':
                            items.Push(i);
                            break;

                        case ')':
                            if (items.Pop() != '(')
                            {
                                return false;
                            }

                            break;

                        case ']':
                            if (items.Pop() != '[')
                            {
                                return false;
                            }

                            break;

                        case '}':
                            if (items.Pop() != '{')
                            {
                                return false;
                            }

                            break;

                        default:
                            break;
                    }
                }

                return items.Count == 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
