using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Ch03Ex02LoopsAndOverflow
    {
        public void loops_and_overflow()
        {
            int max = 500;
            checked
            {
                for (byte i = 0; i < max; i++)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
