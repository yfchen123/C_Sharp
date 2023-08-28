using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Ch03Ex05Operators
    {
        public void operators()
        {
            int x = 3;
            int y = 2 + ++x;
            Console.WriteLine($"x is {x}, y is {y}.");
            int x1 = 3 << 2;
            int y1 = 10 >> 1;
            Console.WriteLine($"x1 is {x1}, y1 is {y1}");
            int x2 = 10 & 8;
            int y2 = 10 | 7;
            Console.WriteLine($"x2 is {x2}, y2 is {y2}");
        }
    }
}
