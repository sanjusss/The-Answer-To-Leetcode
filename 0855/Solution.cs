using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0855
{
    public class ExamRoom
    {
        private SortedDictionary<int, SortedDictionary<int, int>> lengthes = new SortedDictionary<int, SortedDictionary<int, int>>();
        private SortedList<int, List<int>> nbs = new SortedList<int, List<int>>();
        private readonly int max; 

        public ExamRoom(int N)
        {
            max = N;
        }

        public int Seat()
        {
            if (nbs.Count == 0)
            {
                AddSeat(0);
            }

            var maxLength = lengthes.Max();
            var seats = maxLength.Value.Min();
            int i = (seats.Value + seats.Key) >> 1;
            AddSeat(i);
            return i;
        }

        private void AddSeat(int i)
        {
            if (nbs.Count == 0)
            {

            }
        }

        public void Leave(int p)
        {

        }
    }
}
