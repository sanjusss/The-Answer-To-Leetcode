using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050917
{
    public class Solution
    {
        public string ReverseOnlyLetters(string S)
        {
            Stack<char> letters = new Stack<char>();
            List<int> poses = new List<int>();
            int length = S.Length;
            for (int i = 0; i < length; i++)
            {
                if (char.IsLetter(S[i]))
                {
                    letters.Push(S[i]);
                    poses.Add(i);
                }
            }

            StringBuilder res = new StringBuilder(S);
            foreach (var i in poses)
            {
                res[i] = letters.Pop();
            }

            return res.ToString();
        }
    }
}
