namespace _0001
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int count = nums.Length;
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] result = new int[2];
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }

            return null;
        }
    }
}
