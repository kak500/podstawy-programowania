using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace pliki2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");

            DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student\Desktop");

            //Console.WriteLine(studentDir.FullName);
            //Console.WriteLine(studentDir.Name);
            //Console.WriteLine(studentDir.Parent);
            //Console.WriteLine(studentDir.Attributes);
            //Console.WriteLine(studentDir.CreationTime);

            string[] customers = {
                "Anna Nowak",
                "Jan Dzban",
                "Adam Nogaj",
            };

            string path = @"C:\Users\Student\files";
            if (Directory.Exists(path))
            {
                Console.WriteLine("\nCzy chcesz usunąć katalog z plikami?\n[y]/[n]");
                string delete = Console.ReadLine();
                if (delete == "y")
                {
                    Console.WriteLine("Usuwanie w toku...");
                    Directory.Delete(@"C:\Users\Student\files",true);
                }
                else
                {
                    Console.WriteLine("Nie usuwasz pliku");
                }

                if (!Directory.Exists(path))
                {
                    Console.WriteLine("Katalog został usunięty");
                }
                else
                {
                    Console.WriteLine("Katalog nie został usunięty");
                }
            }
            else
            {
                Directory.CreateDirectory(path);
                string textFilePath = @"C:\Users\Student\files\textfile1.txt";
                File.WriteAllLines(textFilePath, customers);

                Console.WriteLine("Katalog został utworzony: {0}", Directory.GetCreationTime(path));
            }



            Console.ReadKey();
        }
    }
}
