using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods6
{
    class Program
    {
        //wyswietlenie zawartosci tablicy

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
        }

        static void Tab1(int[] tab)
        {
            tab = new int[2];
            tab[0] = -1;
            tab[1] = -5;
            
        }

        static void Main(string[] args)
        {
            int[] array = { 2,3,4,5,6 };

            PrintArray(array);

            int[] array2 = new int[2];

            array2[0] = -1;
            array2[1] = 10;

            Tab1(array2);
            Console.WriteLine("///////////");
            foreach (var item in array2)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
