using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
    class Program
    {
        static void tab1(int[] tab)
        {
            tab[0] = 100;
            tab[1] = 50;

            Console.WriteLine("Wartość wewnątrz funkcji: {0} i {1}",tab[0],tab[1]);
        }

        static void Main(string[] args)
        {
            int[] tab = new int[2];

            tab[0] = 5;
            tab[1] = 10;
            Console.WriteLine("Wartości przed funkcją: {0} i {1}",tab[0],tab[1]);

            tab1(tab);

            Console.WriteLine("Wartości po funkcją: {0} i {1}", tab[0], tab[1]);

            Console.ReadKey();
        }
    }
}
