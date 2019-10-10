using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[2] {"lala","text"};
            // Console.WriteLine(array.Length);
            //foreach(string el in array)
            //{
            //    Console.WriteLine(el);
            //}

            List<int> list = new List<int>();

            for (int i = 20; i>5; i--)
            {
                if (i%2 == 0)
                //Console.WriteLine(i);
                list.Add(i);
            }
            // WYŚWIETLANIE Z TABLICY
            foreach (int el in list)
                {
                    Console.Write("{0} ",el);
                }
            Console.WriteLine("\nIlość tych liczb: " + list.Capacity);


            // CHOINKA
            Console.Write("Podaj wysokość choinki:");
            int height = int.Parse(Console.ReadLine());
            for (int i = 1; i<=height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //TRÓJKĄT IN PROGRESS
            Console.Write("Podaj wysokość trojkąta:");
            int heightT = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
