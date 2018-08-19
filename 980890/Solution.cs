using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _980890
{
    public class Solution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            int baseLength = pattern.Length;
            List<int> test = ToInt(pattern);
            List<string> rets = new List<string>();
            foreach (var word in words)
            {
                if (word.Length != baseLength)
                {
                    continue;
                }

                List<int> value = ToInt(word);
                if (AreEqual(test, value))
                {
                    rets.Add(word);
                }
            }

            return rets;
        }

        private bool AreEqual(List<int> a, List<int> b)
        {
            if (a.Count != b.Count)
            {
                return false;
            }

            int count = a.Count;
            for (int i = 0; i < count; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        private List<int> ToInt(string word)
        {
            List<int> ret = new List<int>();
            int index = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var i in word)
            {
                if (dic.ContainsKey(i) == false)
                {
                    dic[i] = index++;
                }

                ret.Add(dic[i]);
            }

            return ret;
        }
    }
}
