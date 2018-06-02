using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0136
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = nums[0];
            int count = nums.Length;
            for (int i = 1; i < count; ++i)
            {
                result = result ^ nums[i];
            }

            return result;
        }
    }
}
