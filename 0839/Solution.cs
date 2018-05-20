using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0839
{
    public class Solution
    {
        private bool IsSimilar(string a, string b)
        {
            int count = a.Length;
            int notSame = 0;
            for (int i = 0; i < count; ++i)
            {
                if (a[i] == b[i])
                {
                    continue;
                }

                ++notSame;
                if (notSame >= 3)
                {
                    return false;
                }
            }

            return true;
        }

        private bool HasSimilarInGroup(List<string> group, string test)
        {
            foreach (var std in group)
            {
                if (IsSimilar(test, std))
                {
                    return true;
                }
            }

            return false;
        }

        public int NumSimilarGroups(string[] A)
        {
            List<List<string>> groups = new List<List<string>>();
            foreach (var test in A)
            {
                bool hasGroup = false;
                foreach (var group in groups)
                {
                    if (HasSimilarInGroup(group, test))
                    {
                        hasGroup = true;
                        group.Add(test);
                        break;
                    }
                }

                if (hasGroup)
                {
                    continue;
                }

                List<string> newGroup = new List<string>();
                newGroup.Add(test);
                groups.Add(newGroup);
            }

            int lastCount;
            do
            {
                lastCount = groups.Count;
                for (int i = 1; i < groups.Count;)
                {
                    bool hasSimilar = false;
                    for (int j = 0; j < i; ++j)
                    {
                        foreach (var test in groups[i])
                        {
                            if (HasSimilarInGroup(groups[j], test))
                            {
                                hasSimilar = true;
                                break;
                            }
                        }

                        if (hasSimilar)
                        {
                            groups[j].AddRange(groups[i]);
                            groups.RemoveAt(i);
                            break;
                        }
                    }

                    if (hasSimilar == false)
                    {
                        ++i;
                    }
                }
            } while (lastCount != groups.Count);

            return groups.Count;
        }
    }
}
