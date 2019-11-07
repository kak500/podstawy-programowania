using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while (true)
            {
                Console.WriteLine("Wprowadź liczbę całkowitą: ");
                try
                {
                    string x = Console.ReadLine();

                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Pamięć");
                }

                try
                {
                    string x = Console.ReadLine();
                    number = uint.Parse(x);
                    break;
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Pamięć");
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wprowadź liczbę w dobrym formacie np. 4");
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Liczba jest poza zakresem");
                    Console.WriteLine("Zakres liczb: od 0 do 4 294 967 295");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pusta wartość");
                }
                Console.WriteLine("Wprowadź liczbę jeszcze raz\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("Liczba: {0}", number);



            Console.ReadKey();
        }
    }
}
