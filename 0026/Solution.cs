using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0026
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int writePos = 1;
            int last = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] == last)
                {
                    continue;
                }

                last = nums[i];
                nums[writePos] = last;
                ++writePos;
            }

            return writePos;
        }
    }
}
