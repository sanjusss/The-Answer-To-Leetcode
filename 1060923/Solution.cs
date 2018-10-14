using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1060923
{
    public class Solution
    {
        private const long mod = 1000000007;

        public int ThreeSumMulti(int[] A, int target)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (var i in A)
            {
                if (counts.ContainsKey(i))
                {
                    ++counts[i];
                }
                else
                {
                    counts[i] = 1;
                }
            }

            long t = 0;
            List<int> nums = counts.Keys.ToList();
            nums.Sort();
            int length = nums.Count;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] > target)
                {
                    break;
                }

                for (int j = i; j < length; j++)
                {
                    for (int k = j; k < length; k++)
                    {
                        if (target != nums[i] + nums[j] + nums[k])
                        {
                            continue;
                        }

                        long ci = counts[nums[i]];
                        long cj = counts[nums[j]];
                        long ck = counts[nums[k]];
                        if (i == j && j == k)
                        {
                            if (ci < 3)
                            {
                                continue;
                            }

                            cj = 1;
                            ck = 0;
                            for (long p = ci; p > 2; --p)
                            {
                                ck += (p - 1) * (p - 2) / 2;
                            }

                            ci = 1;
                        }
                        else if (i == j)
                        {
                            if (ci < 2)
                            {
                                continue;
                            }

                            ci = 1;
                            cj = (cj * (cj - 1)) / 2;
                        }
                        else if (j == k)
                        {
                            if (cj < 2)
                            {
                                continue;
                            }

                            cj = 1;
                            ck = (ck * (ck - 1)) / 2;
                        }

                        t += ci * cj * ck;
                    }
                }
            }

            return (int)(t % mod);
        }
    }
}
