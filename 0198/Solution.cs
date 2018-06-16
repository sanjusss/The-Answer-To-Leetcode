using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0198
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int length = nums.Length;
            switch (length)
            {
                case 0:
                    return 0;

                case 1:
                    return nums[0];

                default:
                    break;
            }

            int[] results = new int[length];
            results[0] = nums[0];
            results[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < length; ++i)
            {
                results[i] = Math.Max(results[i - 1], results[i - 2] + nums[i]);
            }

            return results[length - 1];
        }
    }

    //public class Solution
    //{
    //    public int Rob(int[] nums)
    //    {
    //        int length = nums.Length;
    //        if (length == 0)
    //        {
    //            return 0;
    //        }
    //        else if (length == 1)
    //        {
    //            return nums[0];
    //        }

    //        Dictionary<int, int> results = new Dictionary<int, int>();
    //        results[0] = nums[0];
    //        results[-1] = 0;
    //        results[-2] = 0;
    //        results[-3] = 0;

    //        int start = length - 1;
    //        Stack<int> stack = new Stack<int>();
    //        stack.Push(start);
    //        stack.Push(start - 1);
    //        do
    //        {
    //            int i = stack.Peek();
    //            if (results.ContainsKey(i - 2) && results.ContainsKey(i - 3))
    //            {
    //                results[i] = Math.Max(results[i - 2], results[i - 3]) + nums[i];
    //                stack.Pop();
    //            }
    //            else
    //            {
    //                if (results.ContainsKey(i - 2) == false)
    //                {
    //                    stack.Push(i - 2);
    //                }

    //                if (results.ContainsKey(i - 3) == false)
    //                {
    //                    stack.Push(i - 3);
    //                }
    //            }
    //        } while (stack.Count > 0);

    //        return Math.Max(results[start], results[start - 1]);
    //    }
    //}
}
