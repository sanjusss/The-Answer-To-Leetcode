using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCode
{
    public class InputConvertor
    {
        public static IList<IList<int>> ToListList(string input)
        {
            input = input.Replace("],[", "#");
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            string[] words = input.Split('#');
            IList<IList<int>> result = new List<IList<int>>();
            foreach (var i in words)
            {
                result.Add(ToList(i));
            }

            return result;
        }

        public static IList<int> ToList(string input)
        {
            return new List<int>(ToArray(input));
        }

        public static int[][] ToArrayArray(string input)
        {
            input = input.Replace("],[", "#");
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            string[] words = input.Split('#');
            int[][] rets = new int[words.Length][];
            for (int i = 0; i < words.Length; ++i)
            {
                rets[i] = ToArray(words[i]);
            }

            return rets;
        }

        public static int[] ToArray(string input)
        {
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            string[] words = input.Split(',');
            int[] result = new int[words.Length];
            for (int i = 0; i < words.Length; ++i)
            {
                result[i] = Convert.ToInt32(words[i]);
            }

            return result;
        }

        public static int[,] To2dArray(string input)
        {
            IList<IList<int>> lists = ToListList(input);
            int rowCount = lists.Count;
            int colCount = lists[0].Count;
            int[,] ret = new int[rowCount, colCount];
            for (int i = 0; i < rowCount; ++i)
            {
                for (int j = 0; j < colCount; ++j)
                {
                    ret[i, j] = lists[i][j];
                }
            }

            return ret;
        }
    }
}
