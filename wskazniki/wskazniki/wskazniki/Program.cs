using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            char* x;
            char letter = 'a';

            x = &letter;

            Console.WriteLine("Znak :{0} ",letter);
            //Console.WriteLine("wartość: {0}", *x); // wartość zmiennej
            Console.WriteLine("Adres w pamięci: {0}", (int)x);

            double* numberAddress;
            double number = 2.65;
            
            numberAddress = &number;

            Console.WriteLine("Liczba wynosi: {0}", *numberAddress);
            Console.WriteLine("Liczba wynosi: {0}", numberAddress->ToString());
            Console.WriteLine("Adres number: {0}", (int)numberAddress);
        
            Console.ReadKey();
        }
    }
}
