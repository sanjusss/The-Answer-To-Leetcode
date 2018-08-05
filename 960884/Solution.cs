using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _960884
{
    public class Solution
    {
        private class Decode
        {
            public string code;
            public Int64 length;
            public Int64 start;
            public Int64 repeat;
        }

        public string DecodeAtIndex(string S, int K)
        {
            string code = string.Empty;
            List<Decode> decodes = new List<Decode>();
            for (int i = 0; i < S.Length; i++)
            {
                if (char.IsDigit(S[i]))
                {
                    int repeat = S[i] - '0';
                    if (string.IsNullOrEmpty(code))
                    {
                        decodes[decodes.Count - 1].repeat *= repeat;
                        decodes[decodes.Count - 1].length *= repeat;
                    }
                    else
                    {
                        Int64 lastLength = decodes.Count == 0 ? 0 : decodes.Last().length;
                        Decode decode = new Decode()
                        {
                            code = code,
                            length = (lastLength + code.Length) * repeat,
                            start = lastLength,
                            repeat = repeat
                        };

                        decodes.Add(decode);
                    }

                    code = string.Empty;
                }
                else
                {
                    code += S[i];
                }
            }

            if (decodes.Count == 0)
            {
                return S[K - 1].ToString();
            }
            
            for (int i = 0; i < decodes.Count; ++i)
            {
                if (decodes[i].length < K)
                {
                    continue;
                }

                return FindK(i, decodes, K);
            }

            return null;
        }

        private string FindK(int i, List<Decode> decodes, int K)
        {
            K = K % (int)(decodes[i].length / decodes[i].repeat);
            if (K == 0)
            {
                return decodes[i].code.Last().ToString();
            }

            if (i != 0)
            {
                if (K <= decodes[i - 1].length)
                {
                    return FindK(i - 1, decodes, K);
                }

                K -= (int)decodes[i - 1].length;
            }

            return decodes[i].code[K - 1].ToString();
        }
    }
}
