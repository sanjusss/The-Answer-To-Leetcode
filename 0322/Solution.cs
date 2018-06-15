using System;
using System.Collections.Generic;
using System.Text;

namespace _0322
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0)
            {
                return 0;
            }

            Array.Sort(coins);
            int used = CoinChange(coins, amount, coins.Length);
            return used > 0 ? used : -1;
        }

        public int CoinChange(int[] coins, int amount, int length)
        {
            if (length == 0)
            {
                return 0;
            }

            int num = coins[length - 1];
            if (num == amount)
            {
                return 1;
            }
            else if (num > amount)
            {
                return CoinChange(coins, amount, length - 1);
            }

            int nextUse = CoinChange(coins, amount - num, length);
            if (nextUse == 0)
            {
                return CoinChange(coins, amount, length - 1);
            }
            else
            {
                return 1 + nextUse;
            }
        }
    }
}
