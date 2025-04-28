using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizzBuzz
{
    static class FizzBuzz
    {
        public static void CheckNumber(int number)
        {
            if (number % 3 == 0 && number % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0 && number % 3 != 0) 
            {
                Console.WriteLine("Buzz");
            }
            else if(number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine($"Wpisana liczba to {number}");
            }

        }
    }
}
