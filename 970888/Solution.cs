using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _970888
{
    public class Solution
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            var wordsA = GetWords(A);
            var wordsB = GetWords(B);
            List<string> ret = new List<string>();
            foreach (var i in wordsA)
            {
                if (i.Value == 1 && wordsB.ContainsKey(i.Key) == false)
                {
                    ret.Add(i.Key);
                }
            }

            foreach (var i in wordsB)
            {
                if (i.Value == 1 && wordsA.ContainsKey(i.Key) == false)
                {
                    ret.Add(i.Key);
                }
            }

            return ret.ToArray();
        }

        private Dictionary<string, int> GetWords(string s)
        {
            string[] words = s.Split(' ');
            Dictionary<string, int> ret = new Dictionary<string, int>();
            foreach (var i in words)
            {
                if (ret.ContainsKey(i))
                {
                    ++ret[i];
                }
                else
                {
                    ret[i] = 1;
                }
            }

            return ret;
        }
    }
}
