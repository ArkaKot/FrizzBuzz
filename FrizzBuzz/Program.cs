using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizzBuzz
{
     class Program
    {
         static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Witaj w grze FizzBuzz");
                var fizzBuzz = new FizzBuzz();

                for (; ; )
                {
                   
                    Console.WriteLine("Podaj liczbę: ");
                    var number = GetUserNumber();
                    Console.WriteLine(fizzBuzz.CheckNumber(number));
                }
                           

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Aby zakończyć naciśnij dowolny klawisz");
            }

        }

        private static  int GetUserNumber()
        {
            for (; ; )
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("Podano błędną liczbę, spróbuj ponownie");
                    continue;
                }
                return userNumber;
            }
           
        }
    }
}
