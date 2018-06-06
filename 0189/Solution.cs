using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0189
{
    public class Solution
    {
        //public void Rotate(int[] nums, int k)
        //{
        //    k = k % nums.Length;
        //    if (k <= 0 || nums.Length <= 1)
        //    {
        //        return;
        //    }

        //    int temp = nums[nums.Length - 1];
        //    for (int i = nums.Length - 2; i >= 0; --i)
        //    {
        //        nums[i + 1] = nums[i];
        //    }

        //    nums[0] = temp;
        //    Rotate(nums, k - 1);
        //}
        public void Rotate(int[] nums, int k)
        {
            int length = nums.Length;
            k = k % nums.Length;
            Revert(nums, 0, length - k - 1);
            Revert(nums, length - k, length - 1);
            Revert(nums, 0, length - 1);
        }

        private void Revert(int[] nums, int start, int end)
        {
            int sum = start + end;
            int temp;
            int index;
            int times = (end - start + 1) / 2;
            for (int i = 0; i < times; ++i)
            {
                index = i + start;
                temp = nums[index];
                nums[index] = nums[sum - index];
                nums[sum - index] = temp;
            }
        }
    }
}
