using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Show()
        {
            Console.WriteLine("WSB");
        }

        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik {0} i {1} dodawania: {2}", a, b , result);
        }

        static void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine("Wynik {0} , {1} i {2} dodawania: {3}", a, b,c, result);
        }

        static int Add(int a, int d , int b = 10, int c = 5)
        {

            return a + b + c + d;
        }

        static void data(string name, string surname = "Nowak", int age = 40)
        {
            Console.WriteLine("Imię: {0} \nnazwisko: {1} \nwiek: {2}",name,surname,age);
        }

        static void Main(string[] args)
        {
            Show();
            Add(2,4);
            Add(2, 4, 6);
            Console.WriteLine("Wynik dodawania w funkcji z 4 arg = {0}",Add(2,d:4));

            data("Adam",age:20);

            Console.ReadKey();
        }
    }
}
