using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1070925
{
    public class Solution
    {
        public bool IsLongPressedName(string name, string typed)
        {
            var names = GetChars(name);
            var types = GetChars(typed);
            if (names.Count != types.Count)
            {
                return false;
            }

            int count = names.Count;
            for (int i = 0; i < count; i++)
            {
                if (names[i].Key != types[i].Key ||
                    names[i].Value > types[i].Value)
                {
                    return false;
                }
            }

            return true;
        }

        private List<KeyValuePair<char, int>> GetChars(string name)
        {
            List<KeyValuePair<char, int>> names = new List<KeyValuePair<char, int>>();
            foreach (var i in name)
            {
                int count = names.Count;
                if (count > 0 &&
                    names[count - 1].Key == i)
                {
                    names[count - 1] = new KeyValuePair<char, int>(i, names[count - 1].Value + 1);
                }
                else
                {
                    names.Add(new KeyValuePair<char, int>(i, 1));
                }
            }

            return names;
        }
    }
}
