using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            Console.WriteLine("Podaj liczbę całkowitą");
            while (true)
            {
                string x = Console.ReadLine();
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Podaj jeszcze raz");
            }

            Console.ReadKey();
        }
    }
}
