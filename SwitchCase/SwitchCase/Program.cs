using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Pole kwadratu\n2. Pole koła");
            Console.Write("Wybierz: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //Kwadrat
                    Console.Clear();
                    Console.WriteLine("Obliczanie pola kwadratu");
                    Console.Write("Podaj długość: ");
                    string LengthS = Console.ReadLine();
                    if (double.TryParse(LengthS, out double Length))
                    {
                        Console.WriteLine("Pole kwadratu wynosi: {0}", Length*Length);
                    }
                    break;
                case "2":
                    //koło
                    Console.Clear();
                    Console.WriteLine("Obliczanie pola koła");
                    Console.Write("Podaj promień: ");
                    string RadiusS = Console.ReadLine();
                    if (double.TryParse(RadiusS, out double Radius))
                    {
                        double Field = Math.PI * Math.Pow(Radius, 2.0);
                        Console.WriteLine("Pole koła wynosi: {0:##.##}", Field);
                    }
                    break;
                default:
                    //default
                    Console.WriteLine("Podałeś błędne dane");
                    break;
            }
            Console.ReadKey();
        }
    }
}