using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorLib;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorClass ColorManage = new ColorClass();

            Console.WriteLine("Chcesz zmienić kolor tła czy tekstu?");
            string Choice = Console.ReadLine();
            
            if (Choice == "tla" || Choice == "tła")
            {
                ColorManage.PrintColors();
                ColorManage.getColor();
                ColorManage.ChangeBackground("red");
            }
            if (Choice == "tekstu")
            {
                ColorManage.ChangeForeground("red");
            }



            Console.WriteLine("git");

            Console.ReadKey();
        }
    }
}
