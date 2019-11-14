using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        //napisz funkcje wyświetlającą czy liczba jest parzysta czy nie
        static string checkEven(int x)
        {
            if (x%2 == 0)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }

        // Wyświetlanie sumy cyfr liczby całkowitych

        static int SumDigits(int x)
        {
            int result = 0;
            int Sum;
            //int x;

            //x = int.Parse(number);

            do
            {
                Sum = x % 10;
                result += Sum;
                x = x / 10;
            } while (x!=0);

            return result;
        }

        static void increment (ref int x)
        {
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz fukncji: {0}",x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(checkEven(2));

            Console.WriteLine(SumDigits(12235));


            int x = 3;
            increment(ref x);

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
