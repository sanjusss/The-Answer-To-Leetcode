using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0122
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            int buy = int.MaxValue;
            for (int i = 0; i < prices.Length; ++i)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                }
                else
                {
                    int temp = prices[i] - buy;
                    if (temp > profit)
                    {
                        profit = temp;
                    }
                }
            }

            return profit;
        }
    }
}
