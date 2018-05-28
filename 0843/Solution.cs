using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0843
{
    public class Master
    {
        private readonly string secret;
        private int maxCallTimes;

        public Master(string secret, int maxCallTimes)
        {
            this.secret = secret;
            this.maxCallTimes = maxCallTimes;
        }

        public int Guess(string word)
        {
            int same = 0;
            int count = Math.Min(secret.Length, word.Length);
            for (int i = 0; i < count; ++i)
            {
                if (secret[i] == word[i])
                {
                    ++same;
                }
            }

            --maxCallTimes;
            if (maxCallTimes < 0)
            {
                throw new InvalidOperationException();
            }

            Console.WriteLine(string.Format("猜测为{0},相似字符数量为{1},剩余查找次数{2}。", word, same, maxCallTimes));
            return same;
        }
    }

    public class Solution//public声明需要在提交时去掉。
    {
        public void FindSecretWord(string[] wordlist, Master master)
        {
            List<string> words = new List<string>(wordlist);
            Random random = new Random();
            do
            {
                int index = random.Next(0, words.Count);
                string guessWord = words[index];
                words.RemoveAt(index);
                int similarSize = master.Guess(guessWord);
                if (similarSize == 6)
                {
                    break;
                }

                List<string> nextWords = new List<string>();
                foreach (var i in words)
                {
                    int same = 0;
                    for (int j = 0; j < 6; ++j)
                    {
                        if (i[j] == guessWord[j])
                        {
                            ++same;
                        }
                    }

                    if (same == similarSize)
                    {
                        nextWords.Add(i);
                    }
                }

                words = nextWords;
            } while (true);
        }
    }
}
