using System;
using System.Collections.Generic;
namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=10,i;
            int[] array = new int[n];

            for(i=0; i < array.Length; i++)
            {
                array[i] = i+1;
            }

            for (i = 0; i< array.Length; i++)
            {
                Console.Write("{0}, ",array[i]);
            }

            foreach (int el in array)
            {
                Console.WriteLine(el);
            }
            Console.Clear();


            string[] colors = new string[5];
            Console.WriteLine("Wprowadź kolory: ");
            for(i=0; i< colors.Length; i++)
            {
                colors[i] = Console.ReadLine();
            }
            i = 1;
            Console.Clear();
            foreach(string color in colors)
            {
                Console.WriteLine("kolor{0}: {1}", i, color);
                i++;
            }
            Console.ReadKey();
        }
    }
}
