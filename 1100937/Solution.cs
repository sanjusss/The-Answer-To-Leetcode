using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1100937
{
    public class Solution
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            List<KeyValuePair<string, string>> letters = new List<KeyValuePair<string, string>>();
            List<string> numbers = new List<string>();
            foreach (var log in logs)
            {
                int index = log.IndexOf(' ');
                if (char.IsDigit(log[index + 1]))
                {
                    numbers.Add(log);
                }
                else
                {
                    letters.Add(new KeyValuePair<string, string>(log.Substring(index + 1), log));
                }
            }

            List<string> rets = new List<string>();
            letters.Sort((a, b) =>
            {
                return string.Compare(a.Key, b.Key);
            });
            foreach (var i in letters)
            {
                rets.Add(i.Value);
            }

            rets.AddRange(numbers);
            return rets.ToArray();
        }
    }
}
