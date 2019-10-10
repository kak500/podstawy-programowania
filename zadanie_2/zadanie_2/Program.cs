using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Height;
            int LenghtA;
            double Field;

            Console.WriteLine("-------Obliczanie pola trójkąta---------");

            Console.Write("Podaj długość boku: ");
            string Bok = Console.ReadLine();

            Console.Write("Podaj wysokość: ");
            string Wysokosc = Console.ReadLine();

            if (int.TryParse(Bok, out LenghtA) && int.TryParse(Wysokosc, out Height))
            {
                Console.WriteLine("git");
                Field = 0.5 * (Height * LenghtA);
                Console.WriteLine("Pole trójkąta jest równe: {0}", Field);
            }
            else
            {
                Console.WriteLine("Błędne dane");
            }
            Console.Read();
        }
    }
}
