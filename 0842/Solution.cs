using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0842
{
    public class Solution
    {
        public IList<int> SplitIntoFibonacci(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return new List<int>();
            }

            return Div(S, new List<int>());
        }

        private List<int> Div(string s, List<int> prefix)
        {
            int length = s.Length;
            if (length == 0)
            {
                return prefix;
            }

            if (s.StartsWith("0"))
            {
                if (AddItem(0, prefix))
                {
                    List<int> newPrefix = new List<int>(prefix);
                    newPrefix.Add(0);
                    return Div(s.Remove(0, 1), newPrefix);
                }
                else
                {
                    return new List<int>();
                }
            }
            else
            {
                for (int i = 1; i <= length; i++)
                {
                    int num = 0; ;
                    if (int.TryParse(s.Substring(0, i), out num) == false||
                        AddItem(num, prefix) == false)
                    {
                        continue;
                    }

                    List<int> newPrefix = new List<int>(prefix);
                    newPrefix.Add(num);
                    List<int> result = Div(s.Remove(0, i), newPrefix);
                    if (result.Count > 2)
                    {
                        return result;
                    }
                }
            }

            return new List<int>();
        }

        private bool AddItem(int num, List<int> prefix)
        {
            int count = prefix.Count;
            if (count >= 2)
            {
                return (prefix[count - 2] + prefix[count - 1] == num);
            }
            else
            {
                return true;
            }
        }
    }
}
