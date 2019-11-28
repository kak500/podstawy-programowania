using System;
using biblioteka1_dll;


namespace biblioteka1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass x = new MathClass();

            Console.WriteLine(x.Add(2,5));

            Console.ReadKey();
        }
    }
}
