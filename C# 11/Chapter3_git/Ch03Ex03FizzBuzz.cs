﻿
namespace Chapter3
{
    public class Ch03Ex03FizzBuzz
    {
        public void fizzbuzz()
        {
            for(int i = 0; i < 100; i++) { 
                if (i % 3 == 0 && i % 5 == 0) { 
                    Console.Write("FizzBuzz, ");
                } else if(i % 3 == 0)
                {
                    Console.Write("Fizz, ");
                } else if(i % 5 == 0)
                {
                    Console.Write("Buzz, ");
                }
                else
                {
                    Console.Write(i + ", ");
                }

                if(i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
