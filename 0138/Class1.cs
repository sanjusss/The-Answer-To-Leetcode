using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0138
{
    
    public class RandomListNode
    {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x) { this.label = x; }
    };

    public class Solution
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            var root = head;
            RandomListNode ret = null;
            RandomListNode retHead = null;
            List<RandomListNode> list = new List<RandomListNode>();
            for (int i = 0; head != null; ++i)
            {
                if (ret == null)
                {
                    ret = new RandomListNode(head.label);
                    retHead = ret;
                }
                else
                {
                    retHead.next = new RandomListNode(head.label);
                    retHead = retHead.next;
                }

                retHead.random = head.random;
                list.Add(retHead);

                RandomListNode temp = head.next;
                head.next = new RandomListNode(i);
                head.next.next = temp;
                head = temp;
            }

            foreach (var i in list)
            {
                if (i.random == null)
                {
                    continue;
                }

                i.random = list[i.random.next.label];
            }

            //还原源链表
            head = root;
            while (head != null)
            {
                head.next = head.next.next;
                head = head.next;
            }

            return ret;
        }
    }
}
