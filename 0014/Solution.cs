using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0014
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int arrayCount = strs.Length;
            if (arrayCount == 0)
            {
                return string.Empty;
            }

            if (arrayCount == 1)
            {
                return strs[0];
            }

            int testIndex = 0;
            string test = strs[0];
            int testCount = int.MaxValue;
            foreach (var i in strs)
            {
                if (i.Length < testCount)
                {
                    testCount = i.Length;
                }
            }

            for (testIndex = 0; testIndex < testCount; testIndex++)
            {
                bool continueTest = true;
                for (int j = 1; j < arrayCount; j++)
                {
                    if (strs[j][testIndex] != test[testIndex])
                    {
                        continueTest = false;
                        break;
                    }
                }

                if (continueTest == false)
                {
                    break;
                }
            }

            return test.Substring(0, testIndex);
        }
    }
}
