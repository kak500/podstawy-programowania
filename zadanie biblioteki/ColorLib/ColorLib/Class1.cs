using System;

namespace ColorLib
{
    public class ColorClass
    {
        //public string ColorName;

        public string[] ColorNames = {"red","green","blue","yellow"};

        public void getColor()
        {
            Console.WriteLine("Podaj kolor: ");
            string ColorName = Console.ReadLine();
        }

        public void PrintColors()
        {
            foreach (var item in ColorNames)
            {
                Console.WriteLine("{0}", item);
            }
        }

        public void ChangeBackground(string ColorName)
        {
            if (ColorName == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (ColorName == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (ColorName == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (ColorName == "yellow")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
        }

        public void ChangeForeground(string ColorName)
        {
            if (ColorName == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (ColorName == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (ColorName == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (ColorName == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
}
