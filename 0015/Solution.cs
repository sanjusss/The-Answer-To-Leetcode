using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0015
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int length = nums.Length;
            if (length < 3)
            {
                return result;
            }

            Array.Sort(nums);
            HashSet<int> set = new HashSet<int>(nums);
            int cmin;
            int l = 0;
            int r = length - 1;
            while (l < r)//求最小的cmin，使num[cmin] >= 0;
            {
                cmin = l + ((r - l) >> 1);//向下取整
                if (nums[cmin] < 0)
                {
                    l = cmin + 1;
                }
                else
                {
                    r = cmin;
                }
            }

            if (nums[r] >= 0)
            {
                cmin = r;
                int v = nums[cmin];
                while (cmin < length - 1 && v == nums[cmin + 1])
                {
                    ++cmin;
                }
            }
            else
            {
                return result;
            }

            int a = 0;
            do
            {
                int c = Math.Max(a + 2, cmin);
                int v;

                do
                {
                    v = nums[c];
                    while (c < length - 1 && v == nums[c + 1])
                    {
                        ++c;
                    }

                    v = 0 - nums[a] - nums[c];
                    if (v >= nums[a] && v <= nums[c] && set.Contains(v))
                    {
                        bool success = false;
                        if (nums[a] == v)
                        {
                            if (nums[a + 1] == v)
                            {
                                success = true;
                            }
                        }
                        else if (nums[c] == v)
                        {
                            if (nums[c - 1] == v)
                            {
                                success = true;
                            }
                        }
                        else
                        {
                            success = true;
                        }

                        if (success)
                        {
                            result.Add(new List<int>() { nums[a], v, nums[c] });
                        }
                    }

                    ++c;
                } while (c < length);

                v = nums[a];
                do
                {
                    ++a;
                } while (a < length - 2 && v == nums[a]);
            } while (a < length - 2 && nums[a] <= 0);

            return result;
        }
    }
}
