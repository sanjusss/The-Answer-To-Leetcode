using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0283
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int length = nums.Length;
            int write = 0;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[write] = nums[i];
                    write++;
                }
            }

            for (int i = write; i < length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
