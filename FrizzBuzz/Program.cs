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

                Console.WriteLine("Podaj liczbę: ");
                var number = getUserNumber();

                FizzBuzz.CheckNumber(number);
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

        private static int getUserNumber()
        {
            for (; ; )
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("");
                    continue;
                }
                return userNumber;
            }
           
        }
    }
}
