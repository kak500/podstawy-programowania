using System;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("To jest program który oblicza pole prostokąta");
            Console.Write("Podaj bok a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Podaj bok b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Pole prostokąta wynosi: {0} cm/kw", a * b);
            Console.Read();
        }
    }
}
