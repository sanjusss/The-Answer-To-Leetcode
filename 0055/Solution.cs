using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0055
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            int maxStep = 0;
            int length = nums.Length;
            for (int i = 0; i < length - 1; ++i)
            {
                maxStep = Math.Max(maxStep - 1, nums[i]);
                if (nums[i] == 0 && maxStep <= 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
