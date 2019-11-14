using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static double Operation(string operation, double x, double y)
        {
            //double result;
            if (operation == "Dodawanie")
            {
                return x + y;
            }
            else if (operation == "Odejmowanie")
            {
                return x - y;
            }
            else if (operation == "Mnożenie")
            {
                return x * y;
            }
            else if (operation == "Dzielenie")
            {
                return x / y;
            }
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Prosty kalkulator");
            Console.WriteLine("Wybierz operację");
            string[] operations = { "Dodawanie", "Odejmowanie", "Mnożenie", "Dzielenie", "Wyjście" };

            // Generowanie menu
            int i = 1;
            foreach (var item in operations)
            {
                Console.WriteLine("{0}. {1}", i, item);
                i++;
            }

            uint Choice;

            while (true)
            {
                try
                {
                    string StringChoice = Console.ReadLine();
                    Choice = uint.Parse(StringChoice);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podana dana jest w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba wykracza poza dozwolony zakres");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Nic nie wprowadzono");
                }
                Console.WriteLine("Wprowadź liczbę ponownie");
            }
            double Value1;
            double Value2;
            Console.Clear();

            Console.WriteLine("Wprowadź 1 liczbę: ");
            while (true)
            {
                string StrValue1 = Console.ReadLine();
                try
                {
                    Value1 = double.Parse(StrValue1);
                    break;
                }
                catch (FormatException) { Console.WriteLine("Podana dana jest w złym formacie"); }

                catch (OverflowException) { Console.WriteLine("Liczba wykracza poza dozwolony zakres"); }

                catch (ArgumentNullException) { Console.WriteLine("Nic nie wprowadzono"); }

                Console.WriteLine("Wprowadź liczbę ponownie liczbę 2: ");
            }

            Console.WriteLine("Wprowadź 2 liczbę: ");
            while (true)
            {
                string StrValue2 = Console.ReadLine();
                try
                {
                    Value2 = double.Parse(StrValue2);
                    break;
                }
                catch (FormatException) { Console.WriteLine("Podana dana jest w złym formacie"); }

                catch (OverflowException) { Console.WriteLine("Liczba wykracza poza dozwolony zakres"); }

                catch (ArgumentNullException) { Console.WriteLine("Nic nie wprowadzono"); }

                Console.WriteLine("Wprowadź liczbę ponownie liczbę 2: ");
            }

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Wybrano {0}", operations[Choice-1]);
                    Console.WriteLine("Wynik tego działania to: {}", Operation(operations[Choice-1],Value1,Value2));
                    break;
                case 2:
                    Console.WriteLine("Wybrano {0}", operations[Choice - 1]);
                    Console.WriteLine("Wynik tego działania to: {}", Operation(operations[Choice - 1], Value1, Value2));
                    break;
                case 3:
                    Console.WriteLine("Wybrano {0}", operations[Choice - 1]);
                    Console.WriteLine("Wynik tego działania to: {}", Operation(operations[Choice - 1], Value1, Value2));
                    break;
                case 4:
                    Console.WriteLine("Wybrano {0}", operations[Choice - 1]);
                    if (Value2 != 0)
                    {
                        Console.WriteLine("Wynik tego działania to: {}", Operation(operations[Choice - 1], Value1, Value2));
                    }
                    else
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                    }
                    break;
                default:
                    Console.WriteLine("Wciśnij dowolny klawisz by zamknąć program");
                    break;
            }

            Console.ReadKey();
        }
    }
}
