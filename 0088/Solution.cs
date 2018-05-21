using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0088
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] source1 = nums1.Take(m).ToArray();
            int i = 0;
            int j = 0;
            while (i < m && j < n)
            {
                if (source1[i] <= nums2[j])
                {
                    nums1[i + j] = source1[i];
                    ++i;
                }
                else
                {
                    nums1[i + j] = nums2[j];
                    ++j;
                }
            }

            if (i < m)
            {
                Array.Copy(source1, i, nums1, i + j, m - i);
            }
            else if (j < n)
            {
                Array.Copy(nums2, j, nums1, i + j, n - j);
            }
        }
    }
}
