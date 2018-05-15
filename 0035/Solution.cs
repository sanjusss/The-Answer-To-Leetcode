using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0035
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int index;
            while (left < right)
            {
                index = left + ((right + 1 - left) >> 1);
                if (nums[index] < target)
                {
                    left = index;
                }
                else
                {
                    right = index - 1;
                }
            }

            if (nums[left] < target)
            {
                return left + 1;
            }
            else
            {
                return left;
            }
        }
    }
}
