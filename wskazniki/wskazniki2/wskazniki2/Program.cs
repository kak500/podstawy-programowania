using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki2
{
    class Program
    {
        unsafe static void swap(int* x, int* y)
        {
            int pom = *x;
            *x = *y;
            *y = pom;
        }
        unsafe static void Main(string[] args)
        {
            int* xPointer;
            int* yPointer;

            int x = 5;
            int y = 10;

            Console.WriteLine("Przed zamianą x={0}, y={1}",x,y);

            xPointer = &x;
            yPointer = &y;
            swap(xPointer, yPointer);

            Console.WriteLine("Po zamianie x={0}, y={1}", x, y);

            Console.ReadKey();
        }
    }
}
