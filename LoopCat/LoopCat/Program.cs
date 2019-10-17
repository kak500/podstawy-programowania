using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace LoopCat
{
    class Program
    {
        static void Main(string[] args)
        {

            //do while dla danych wartosci zmienijacych sie w przedziale od 0 do 15 obliczy wartosc funkcji y=4x
            int y, x = 0;
            Console.WriteLine("--------Zadanie 1-------");
            do
            {
                y = 4 * x;
                Console.WriteLine("x = {0}\ty = {1}", x, y);
                x++;
            } while (x <= 15);

            //napisz program znajdujacy sie powyzej za pomoca petli while
            Console.WriteLine("--------Zadanie 2-------");
            x = 0;
            while(x <= 15)
            {
                y = 4 * x;
                Console.WriteLine("x = {0}\ty = {1}", x, y);
                x++;
            }

            //napisz pr ktory za pomoca instrukcji while dla danych wartosci x zmieniajacych sie w przedziale 1 - 50 obliczy ich sumę
            Console.WriteLine("--------Zadanie 3-------");
            int suma = 0;
            x = 1;
            while (x <= 50)
            {
                suma += x;
                x++;
            }
            Console.WriteLine("Suma wynosi: {0}", suma);

            // sumuje liczby nieparzyste z 1 do 10
            Console.WriteLine("--------Zadanie 4-------");
            suma = 0;
            for (int i = 1; i <= 10; i++)
            {
                if(i%2 !=0)
                    suma += i;
            }
            Console.WriteLine("Suma wynosi: {0}", suma);

            Console.WriteLine("--------Zadanie 5 tabliczka FOR-------");
            int iloczyn = 1;
            for (int i=1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    iloczyn = j * i;
                    Console.Write("{0} \t", iloczyn);
                   // Console.WriteLine(iloczyn);
                }
                Console.WriteLine();
            }
            // Tabliczka mnozenia Do While
            Console.WriteLine("--------Zadanie 6 tabliczka DO WHILE-------");
            iloczyn = 1;
            int row = 1;
            int column = 1;
            do
            {
                do
                {
                    iloczyn = row * column;
                    Console.Write("{0} \t", iloczyn);
                    column++;
                } while (column<=10);
                column = 1;
                row++;
                Console.WriteLine();
            } while (row<=10);

            //for (int i=0; i<10; i++)
            //{
            //    for(int j)
            //}
            // wyswietli duze litery alfabetu od A do Z i od Z do A z wykrzystaniem petli for
            char znak = 'A';
            for (znak = 'A'; znak<='Z'; znak++)
            {
                if(znak!='Z')
                    Console.Write("{0}, ", znak);
                else
                    Console.Write("{0}\n", znak);
            }
            
            for (znak = 'Z'; znak >= 'A'; znak--)
            {
                if(znak!='A')
                    Console.Write("{0}, ", znak);
                else
                    Console.Write("{0}\n ", znak);
            }
            //
            List<int> lista = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                if (i == 3 || i == 6 || i == 7)
                        continue;
                    else
                        Console.Write(i);

            }
            for (int i = 0; i < 25; i++)
            {
                Console.Clear();
                Console.WriteLine("{0}",i);
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}
