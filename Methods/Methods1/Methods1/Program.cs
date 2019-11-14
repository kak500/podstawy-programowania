using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using First_name;
//using Second_name;

using Outer.Middle.Inner;
namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("WSB");

            First_name.namespace_1 obj1 = new First_name.namespace_1();
            obj1.show();

            Second_name.namespace_1 obj2 = new Second_name.namespace_1();
            obj2.show();

            //Outer.Middle.Inner.Prog obj3 = new Outer.Middle.Inner.Prog();

            Prog obj3 = new Prog();

            Console.WriteLine("Wynik dodawania {0}",obj3.Add(2, 4));
            

            Console.ReadKey();
        }
    }
}

namespace First_name
{
    class namespace_1
    {
        public void show()
        {
            Console.WriteLine("Pierwsza przestrzeń nazw");
        }
    }
}

namespace Second_name
{
    class namespace_1
    {
        public void show()
        {
            Console.WriteLine("Druga przestrzeń nazw");
        }
    }
}

namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Prog
            {
                public int x;
                public int y;

                public int Add(int x, int y)
                {
                    return x + y;
                }
            }
        }
    }
}