using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0017
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }

            for (int i = digits.Length - 1; i >= 0; --i)
            {
                char[] letters = DigitToChar(digits[i]);
                result = LetterCombinations(result, letters);
            }

            return result;
        }

        private List<string> LetterCombinations(List<string> strs, char[] letters)
        {
            List<string> result = new List<string>();
            if (strs.Count == 0)
            {
                foreach (var letter in letters)
                {
                    result.Add(letter.ToString());
                }
            }
            else
            {
                foreach (var str in strs)
                {
                    foreach (var letter in letters)
                    {
                        result.Add(letter + str);
                    }
                }
            }

            return result;
        }

        private char[] DigitToChar(char digit)
        {
            switch (digit)
            {
                case '2':
                    return new char[] { 'a', 'b', 'c' };

                case '3':
                    return new char[] { 'd', 'e', 'f' };

                case '4':
                    return new char[] { 'g', 'h', 'i' };

                case '5':
                    return new char[] { 'j', 'k', 'l' };

                case '6':
                    return new char[] { 'm', 'n', 'o' };

                case '7':
                    return new char[] { 'p', 'q', 'r', 's' };

                case '8':
                    return new char[] { 't', 'u', 'v' };

                case '9':
                    return new char[] { 'w', 'x', 'y', 'z' };

                case '0':
                    return new char[] { ' ' };

                case '*':
                    return new char[] { '+' };

                case '1':
                default:
                    return null;
            }
        }
    }
}
