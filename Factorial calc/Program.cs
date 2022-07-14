using System;

namespace Factorial_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int n = 0;
            int summ = 0; 
            int response = 0;
            int sub = 0;
            while (response != -1)
            {
                Console.WriteLine(@"Enter 0 to calculate factorial" + Environment.NewLine +
                                    "Enter -1 to exit" + Environment.NewLine +
                                    "Enter 1 to calculate summ all numbers to yours" + Environment.NewLine +
                                    "Enter 2 to calculate Subtraction of numbers" + Environment.NewLine +
                                    "Enter -2 to print all results");

                response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 0:
                        {
                            Console.WriteLine("Enter number of factorial,which u want");
                            a = int.Parse(Console.ReadLine());
                            n = a;
                                if (a > 0)
                            {

                                for (int i = n - 1; i > 0; i--)
                                {
                                    n *= i;
                                }
                                Console.WriteLine($"factorial chisla {a} ! = {n}");
                            }
                            if (a == 0)
                            {
                                Console.WriteLine($"factorial {a} ! = 1");
                            }
                            if (a < 0)
                            {
                                Console.Write("VVedite polozhitelnoe chislo");
                            }
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("enter the number up to which the amount will be calculated ");
                            b = int.Parse(Console.ReadLine());
                                for (int i = 1; i <= b;i++)
                            {
                                summ = summ + i;
                            
                            }
                            Console.WriteLine($"Summ of all numbers to yours:{summ}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter 2 numbers to substractions {1}-{2}");
                            c = int.Parse(Console.ReadLine());
                            d = int.Parse(Console.ReadLine());
                            sub = c - d;
                            Console.WriteLine(sub);
                            break;
                        }
                    case -2:
                        {
                            Console.WriteLine($"factorial of {a} is {n}");
                            Console.WriteLine($"Summ of all numbers to {b} :{summ}");
                            Console.WriteLine($"substractions {c}-{d} :{sub}");
                            break;
                        }
                    case -1:
                        {
                            Console.WriteLine("YOU Exited programm");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("wrong number");
                            break;
                        }
                } 
          }
        }
    }
}
