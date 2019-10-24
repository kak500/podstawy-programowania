using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach(int el in tab)
            {
                Console.WriteLine(el);
            }
            int i = 0;
            int size = tab.Length;
            size--;

            foreach (int el in tab)
            {
                if (i == 0)
                {
                    Console.WriteLine("Pierwszy element - {0} ", tab[0]);
                }
                if (i == size)
                {
                    Console.WriteLine("ostatni element - {0}", tab[size]);
                }
                else
                {
                    Console.WriteLine("Kolejny element - {0}", tab[i]);
                }
                i++;
            }

            Console.WriteLine("--------------------");
            // utworz tablice ktorej rozmiar podaje uzytkownik nastepnie podaje kolory z klawiatury

            string ArraySize;
            int CheckedArraySize;
            
            do
            {
                Console.Write("Podaj ilość kolorów: ");
                ArraySize = Console.ReadLine();

            } while (int.TryParse(ArraySize, out CheckedArraySize) == false);

            // Console.WriteLine(CheckedSize);

            string[] Colors = new string[CheckedArraySize];

            for (i = 0; i < Colors.Length; i++)
            {
                Console.Write("Podaj kolor: ");
                Colors[i] = Console.ReadLine();
            }
            i = 0;
            Console.WriteLine("FOREACH");
            foreach (string Color in Colors)
            {
                Console.WriteLine("Kolor {0}: {1}", i+1, Color);
                i++;
            }
            Console.WriteLine("WHILE");
            i = 0;
            while (i<CheckedArraySize)
            {
                Console.WriteLine("Kolor {0}: {1}", i+1, Colors[i]);
                i++;
            }

            //Console.WriteLine(System.Drawing.Color.Red.ToString());

            Console.WriteLine("--------------");
            Console.Clear();

             int[,] TwoDimArray = new int[4, 4]
                {
                    {1,2,3,4},
                    {5,6,7,8},
                    {9,10,11,12},
                    {13,14,15,16}
                };

            for (i = 0; i < TwoDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDimArray.GetLength(1); j++)
                {
                    Console.WriteLine("Tab[{0}][{1}] = {2}", i, j, TwoDimArray[i,j]);
                }
            }

            for (i = 0; i < TwoDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDimArray.GetLength(1); j++)
                {
                    Console.Write("{0}\t ", TwoDimArray[i,j]);
                }
                Console.WriteLine();
            }

            // utwórz tab 2D o wym 3x3 i zainicjuj ją danymi i * 3 +j

            int[,] TwoDimArray2 = new int[3, 3];

            for (i = 0; i < TwoDimArray2.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDimArray2.GetLength(1); j++)
                {
                    TwoDimArray2[i, j] = i * 3 + j;
                    Console.Write("{0}\t", TwoDimArray2[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("-------------");
            // deklaracja 2D nieregularnej
            string[][] country = new string[4][];

            //Console.WriteLine("Rozmiar zewnetrznego rozmiaru: {}", country.Length);

            int[][] numbers = new int[3][] 
            {
                new int[] {1},
                new int[] {1,2,3,4,5},
                new int[] {6,7}
            };

            for (i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.WriteLine("Tab[{0}][{1}] = {2}", i, j, numbers[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
