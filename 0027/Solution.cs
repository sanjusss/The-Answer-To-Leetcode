using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0027
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null)
            {
                return 0;
            }

            int writePos = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] == val)
                {
                    continue;
                }

                if (writePos != i)
                {
                    nums[writePos] = nums[i];
                }

                ++writePos;
            }

            return writePos;
        }
    }
}
