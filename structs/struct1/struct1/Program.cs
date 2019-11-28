using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct1
{
    
    class Program
    {
        public struct Punkt
        {
            public int x;
            public int y;

        }
        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt();
            Punkt punkt2 = new Punkt();

            punkt1.x = 100;
            punkt1.y = 200;

            Console.WriteLine("Punkt1.x wynosi {0}\nPunkt1.y wynosi {1}", punkt1.x, punkt1.y);
            Console.ReadKey();
        }
    }
}
