using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0846
{
    public class Solution
    {
        public bool IsNStraightHand(int[] hand, int W)
        {
            int length = hand.Length;
            int groupCount = Math.DivRem(length, W, out int remain);
            if (remain > 0)
            {
                return false;
            }

            List<int> nums = new List<int>(hand);
            nums.Sort();
            for (int i = 0; i < groupCount; ++i)
            {
                if (CanRemoveNStraightNumbers(nums, W) == false)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CanRemoveNStraightNumbers(List<int> nums, int singleLength)
        {
            int start = nums.First();
            nums.Remove(start);
            for (int i = start + 1; i < start + singleLength; ++i)
            {
                if (nums.Remove(i) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
