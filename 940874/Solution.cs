using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _940874
{
    public class Solution
    {
        private struct Point
        {
            public int x;
            public int y;

            public override bool Equals(object obj)
            {
                if (obj == null ||
                    obj.GetType() != typeof(Point))
                {
                    return false;
                }

                Point t = (Point)obj;
                return x == t.x && y == t.y;
            }

            public override int GetHashCode()
            {
                return x * 37 + y;
            }
        };


        public int RobotSim(int[] commands, int[][] obstacles)
        {
            HashSet<Point> points = new HashSet<Point>();
            foreach (var i in obstacles)
            {
                points.Add(new Point()
                {
                    x = i[0],
                    y = i[1]
                });
            }

            Point last = new Point();
            Point next = new Point();
            int maxLength = 0;
            int y = 1;
            int x = 0;
            int d = 0;
            foreach (var c in commands)
            {
                if (c == -1)
                {
                    d = (d + 1) % 4;
                }
                else if (c == -2)
                {
                    d = (d + 3) % 4;
                }
                else
                {
                    switch (d)
                    {
                        case 0:
                            x = 0;
                            y = 1;
                            break;

                        case 1:
                            x = 1;
                            y = 0;
                            break;

                        case 2:
                            x = 0;
                            y = -1;
                            break;

                        case 3:
                            x = -1;
                            y = 0;
                            break;

                        default:
                            break;
                    }

                    next.x = last.x;
                    next.y = last.y;
                    for (int i = 1; i <= c; ++i)
                    {
                        next.x += x;
                        next.y += y;
                        if (points.Contains(next))
                        {
                            break;
                        }
                        
                        last.x = next.x;
                        last.y = next.y;
                    }

                    maxLength = Math.Max(maxLength, last.x * last.x + last.y * last.y);
                }
            }

            return maxLength;
        }
    }
}
