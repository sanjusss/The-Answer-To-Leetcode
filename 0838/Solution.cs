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
            string last = dominoes;
            StringBuilder next = new StringBuilder(dominoes);
            int count = dominoes.Length;
            for (int i = 0; i < count; ++i)
            {
                switch (last[i])
                {
                    case '.':
                        for (int j = i + 1; j < count; ++j)
                        {
                            if (last[j] == '.')
                            {
                                continue;
                            }
                            else if (last[j] == 'R')
                            {
                                i = j - 1;
                                break;
                            }
                            else
                            {
                                for (int k = i; k < j; ++k)
                                {
                                    next[k] = 'L';
                                }

                                i = j;
                                break;
                            }
                        }

                        break;

                    case 'R':
                        for (int j = i + 1; j < count; ++j)
                        {
                            if (last[j] == '.')
                            {
                                if (j == count - 1)
                                {
                                    for (int k = i + 1; k <= j; ++k)
                                    {
                                        next[k] = 'R';
                                    }

                                    i = j - 1;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else if (last[j] == 'R')
                            {
                                for (int k = i + 1; k < j; ++k)
                                {
                                    next[k] = 'R';
                                }

                                i = j - 1;
                                break;
                            }
                            else
                            {
                                int midLength = (j - i - 1) / 2;
                                for (int k = 1; k <= midLength; ++k)
                                {
                                    next[i + k] = 'R';
                                    next[j - k] = 'L';
                                }

                                i = j;
                                break;
                            }
                        }

                        break;

                    default:
                        break;
                }
            }

            return next.ToString();
        }
    }
}
