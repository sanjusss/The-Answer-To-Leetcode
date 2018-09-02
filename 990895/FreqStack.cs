using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _990895
{
    public class FreqStack
    {
        private Dictionary<int, int> v2count = new Dictionary<int, int>();
        private Dictionary<int, HashSet<int>> count2v = new Dictionary<int, HashSet<int>>();
        private List<int> stack = new List<int>();


        public FreqStack()
        {

        }

        public void Push(int x)
        {
            int oldCount = 0;
            if (v2count.ContainsKey(x))
            {
                oldCount = v2count[x];
            }

            int newCount = oldCount + 1;
            v2count[x] = newCount;
            if (oldCount > 0)
            {
                count2v[oldCount].Remove(x);
                if (count2v[oldCount].Count == 0)
                {
                    count2v.Remove(oldCount);
                }
            }

            if (count2v.ContainsKey(newCount) == false)
            {
                count2v[newCount] = new HashSet<int>();
            }

            count2v[newCount].Add(x);
            stack.Add(x);
        }

        public int Pop()
        {
            int oldCount = int.MinValue;
            foreach (var i in count2v)
            {
                oldCount = Math.Max(oldCount, i.Key);
            }

            int newCount = oldCount - 1;
            var list = count2v[oldCount];
            int ret = int.MinValue;
            for (int i = stack.Count - 1; i >= 0; --i)
            {
                if (list.Contains(stack[i]))
                {
                    ret = stack[i];
                    stack.RemoveAt(i);
                    break;
                }
            }

            list.Remove(ret);
            if (list.Count == 0)
            {
                count2v.Remove(oldCount);
            }

            if (newCount > 0)
            {
                v2count[ret] = newCount;
                if (count2v.ContainsKey(newCount) == false)
                {
                    count2v[newCount] = new HashSet<int>();
                }

                count2v[newCount].Add(ret);
            }
            else
            {
                v2count.Remove(ret);
            }

            return ret;
        }
    }
}
