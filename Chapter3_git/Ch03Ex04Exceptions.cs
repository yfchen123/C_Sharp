using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Ch03Ex04Exceptions
    {
        public void exception_handling()
        {
            try
            {
                byte first;
                Console.WriteLine("Enter in a number between 0 and 255: ");
                first = Byte.Parse(Console.ReadLine());
                byte second;
                Console.WriteLine("Enter another number between 0 and 255: ");
                second = Byte.Parse(Console.ReadLine());
                Console.WriteLine($"{first} divided by {second} is {first / second}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string was not in correct format.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero!!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter a number between 0 and 255 please, that number is not in " +
                    "the correct range.");
            }
        }
    }
}
