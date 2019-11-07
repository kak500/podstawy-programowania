using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ExceptionsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;

            a--;
            b++;

            Console.WriteLine("Zmienna a = {0}", a);
            Console.WriteLine("Zmienna b = {0}", b);

            // typ referencyjny

            int[] TabA = { 1, 1, 1, 1 };
            int[] TabB = TabA;

            TabA[2] = 70;
            TabB[0] = 25;

            Console.WriteLine("Tablica A: ");
            foreach (int item in TabA)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\nTablica B: ");
            foreach (int item in TabB)
            {
                Console.Write("{0} ", item);
            }

            // uproszczone wyrazenia inicjalizacji tablic

            char[] vowels = { 'a', 'e', 'i' };
            Console.WriteLine(vowels[0]);

            int[,] age =
            {
                {20,30 },
                {20,30},
                {20,30 }
            };


            Console.WriteLine("{0}", age[1, 1]);

            string[][] name =
            {
                new string[] {"Anna"},
                new string[] {"Anna","Janusz"},
                new string[] {"Anna"}
            };

            Console.WriteLine(name[1][0]);

            Console.WriteLine("Ilość wymiarow: {0}",vowels.Rank);
            Console.WriteLine("Ilość wymiarow: {0}", age.Rank);
            Console.WriteLine("Ilość wymiarow: {0}", name.Rank);

            // kopiowanie tablic

            int[] tablica = { 1, 2, 3, 4, 5 };
            int[] tablicaKopia = new int[5];

            tablica.CopyTo(tablicaKopia,0);

            foreach (int item in tablicaKopia)
            {
                Console.Write("{0}, ", item);
            }

            int[] tablicaKopia2 = new int[5];

            Array.Copy(tablica, tablicaKopia2, tablica.Length);

            foreach (int item in tablicaKopia2)
            {
                Console.Write("{0}, ", item);
            }

            Console.ReadKey();
        }
    }
}
