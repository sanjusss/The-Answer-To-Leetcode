using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0838
{
    public class Solution
    {
        public string PushDominoes(string dominoes)
        {
            string last;
            StringBuilder next = new StringBuilder(dominoes);
            string result = dominoes;
            int count = dominoes.Length;
            do
            {
                last = result;
                for (int i = 0; i < count; ++i)
                {
                    switch (last[i])
                    {
                        case '.':
                            if (i < count - 1 &&
                                last[i + 1] == 'L')
                            {
                                next[i] = 'L';
                                ++i;
                            }

                            break;

                        case 'R':
                            if (i < count - 1 &&
                                last[i + 1] == '.')
                            {
                                if (i < count - 2 &&
                                    last[i + 2] == 'L')
                                {
                                    i += 2;
                                }
                                else
                                {
                                    next[i + 1] = 'R'; 
                                }
                            }

                            break;

                        default:
                            break;
                    }
                }

                result = next.ToString();
            } while (result != last);

            return result;
        }
    }
}
