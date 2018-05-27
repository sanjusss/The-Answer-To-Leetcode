using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0841
{
    public class Solution
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            int roomsCount = rooms.Count;
            if (roomsCount <= 1)
            {
                return true;
            }

            HashSet<int> locked = new HashSet<int>();
            HashSet<int> unused = new HashSet<int>();
            HashSet<int> used = new HashSet<int>();
            used.Add(0);
            AddKeys(unused, used, rooms[0], roomsCount);

            for (int i = 1; i < roomsCount; ++i)
            {
                locked.Add(i);
            }

            while (unused.Count > 0)
            {
                HashSet<int> usedInTurn = new HashSet<int>();
                foreach (var i in unused)
                {
                    if (locked.Remove(i) == false)
                    {
                        continue;
                    }

                    usedInTurn.Add(i);
                }

                if (usedInTurn.Count == 0)
                {
                    break;
                }

                foreach (var i in usedInTurn)
                {
                    AddKeys(unused, used, rooms[i], roomsCount);
                    unused.Remove(i);
                    used.Add(i);
                }
            }

            return locked.Count == 0;
        }

        private void AddKeys(HashSet<int> unused, HashSet<int> used, IList<int> room, int roomsCount)
        {
            foreach (var i in room)
            {
                if (i < 0 || i >= roomsCount)
                {
                    continue;
                }

                if (used.Contains(i))
                {
                    continue;
                }

                unused.Add(i);
            }
        }
    }
}
