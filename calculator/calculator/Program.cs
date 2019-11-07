using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static bool CheckParseException(string value)
        {
            double x;
            
                try
                {
                    x = float.Parse(value);
                   
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dana podana w złym formacie, wprowadź liczbę");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba znajduję się poza zakresem");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Nie wprowadzono nic");
                }
            
            return true;

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Prosty kalkulator\n-----------------");
            Console.WriteLine("Wybierz operację poprzez wpisanie liczby odpowiadającej danej operacji");
            Console.WriteLine("1. Dodawanie\n2.Odejmowanie\n3.Mnożenie\n4.Dzielenie\n5.Potęgowanie");

            uint Choice;

            while (true)
            {
                string ChoiceUnckecked = Console.ReadLine();
                try
                {
                    Choice = uint.Parse(ChoiceUnckecked);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dana podana w złym formacie, wprowadź liczbę");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba znajduję się poza zakresem");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Nie wprowadzono nic");
                }
                Console.WriteLine("Spróbuj wprowadzić liczbę jeszcze raz");

            }

            switch (Choice)
            {
                case 1:
                    double Value1;
                    Console.WriteLine("Wprowadź liczbę 1: ");
                    while (true)
                    {
                        string StrValue1 = Console.ReadLine();
                        try
                        {
                            Value1 = uint.Parse(StrValue1);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Dana podana w złym formacie, wprowadź liczbę");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Liczba znajduję się poza zakresem");
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("Nie wprowadzono nic");
                        }
                        Console.WriteLine("Spróbuj wprowadzić liczbę jeszcze raz");
                    }
                    break;
                    
                    
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }
}
