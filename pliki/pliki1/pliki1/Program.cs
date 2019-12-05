using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace pliki1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");

            DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student\Desktop");

            Console.WriteLine(studentDir.FullName);
            Console.WriteLine(studentDir.Name);
            Console.WriteLine(studentDir.Parent);
            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.CreationTime);

            string[] customers = {
                "Anna Nowak",
                "Jan Dzban",
                "Adam Nogaj",
            };

            //Directory.Delete(@"C:\Users\Student\files");

            string path = @"C:\Users\Student\files";
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("\nŚcieżka już istnieje");

                }
                else
                {
                    Directory.CreateDirectory(path);
                    string textFilePath = @"C:\Users\Student\files\textfile1.txt";
                    File.WriteAllLines(textFilePath, customers);

                    Console.WriteLine("Katalog został utworzony: {0}", Directory.GetCreationTime(path));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: {0}", e.Message);
            }


         


            Console.ReadKey();
        }
    }
}
