using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCode
{
    public static class Permutation
    {
        /// <summary>
        /// 获取全排列，第一次调用前必须从小到大排序。
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="list">全排列数组</param>
        /// <returns>是否生成成功。</returns>
        public static bool NextPermutation<T>(IList<T> list)
            where T : IComparable<T>
        {
            int topIndex = -1;
            int length = list.Count;
            for (int i = length - 1; i > 0; --i)
            {
                if (list[i].CompareTo(list[i - 1]) > 0)
                {
                    topIndex = i;
                    break;
                }
            }

            if (topIndex < 0)
            {
                list.Reverse(0);
                return false;
            }

            int swapIndex = topIndex;
            for (int i = topIndex + 1; i < length; ++i)
            {
                if (list[topIndex - 1].CompareTo(list[i]) >= 0)
                {
                    break;
                }
                else
                {
                    swapIndex = i;
                }
            }

            list.Swap(swapIndex, topIndex - 1);
            list.Reverse(topIndex);
            return true;
        }

        public static void Swap<T>(this IList<T> list, int a, int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        public static void Reverse<T>(this IList<T> list, int index)
        {
            int max = list.Count - 1;
            int length = (max - index) / 2;
            for (int i = 0; i <= length; ++i)
            {
                list.Swap(index + i, max - i);
            }
        }
    }
}
