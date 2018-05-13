using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0833
{
    public class Solution
    {
        public string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets)
        {
            int count = Math.Min(Math.Min(indexes.Length, sources.Length), targets.Length);
            if (count == 0)
            {
                return S;
            }

            List<KeyValuePair<int, int>> sortedIndexes = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < count; ++i)
            {
                sortedIndexes.Add(new KeyValuePair<int, int>(i, indexes[i]));
            }
            sortedIndexes.Sort((a, b) =>
            {
                if (a.Value == b.Value)
                {
                    return 0;
                }

                return a.Value < b.Value ? -1 : 1;
            });

            string result = string.Empty;
            int lastIndex = -1;
            for (int i = 0; i < count; ++i)
            {
                int index = sortedIndexes[i].Key;
                if (indexes[index] + sources[index].Length > S.Length ||
                    S.Substring(indexes[index], sources[index].Length) != sources[index])
                {
                    continue;
                }

                if (lastIndex == -1)
                {
                    if (indexes[index] > 0)
                    {
                        result = S.Substring(0, indexes[index]);
                    }
                }
                else 
                {
                    result += S.Substring(lastIndex + 1, indexes[index] - (lastIndex+ 1));
                }

                result += targets[index];
                lastIndex = indexes[index] + sources[index].Length - 1;
            }

            if (lastIndex == -1)
            {
                result = S;
            }
            else if (lastIndex < S.Length - 1)
            {
                result += S.Substring(lastIndex + 1);
            }

            return result;
        }
    }
}
