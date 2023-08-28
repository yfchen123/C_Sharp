using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    public class Ch04Ex02PrimeFactorsLib
    {
        public static String PrimeFactors(int number)
        {
            String output = $"Prime factors of {number} are: ";
            for(int i = 2; i <= number; i++)
            {
                if(IsPrime(i) && i == number && number % i == 0) {
                    output += i;
                }
                else if (IsPrime(i) && number % i == 0)
                {
                    while(number % i == 0)
                    {
                        if(number / i == 1)
                        {
                            output += $"{i}";
                            number /= i;
                            return output;
                        }
                        else
                        {
                            output += $"{i} x ";
                            number /= i;
                        }
                    }
                    
                }
            }
            return output;
        }

        private static bool IsPrime(int number)
        {
            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
