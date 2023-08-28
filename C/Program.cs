using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Calculator
{
    internal class Program
    {
        static void add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = " + (num1 + num2).ToString());

        }

        static void sub(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = " + (num1 - num2).ToString());
        }

        static void mul(double num1, double num2)
        {
            Console.WriteLine($"{num1} * {num2} = " + (num1 * num2).ToString());
        }

        static void div(double num1, double num2)
        {
            Console.WriteLine($"{num1} / {num2} = " + (num1 / num2).ToString());
        }

        static bool back()
        {
            while (true)
            {
                Console.Write("\nBack [b]: ");
                string geri = (Console.ReadLine());
                if (geri == "b")
                {
                    Console.Clear();
                    break;
                }
                else
                    continue;
            }
            return true;
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Calculator");

                Console.WriteLine("\nAdd         [1]");
                Console.WriteLine("Subtraction [2]");
                Console.WriteLine("Multiply    [3]");
                Console.WriteLine("Division    [4]");
		Console.WriteLine("Exit        [5]");

                Console.Write("\nSelect: ");
                int select = Convert.ToInt32(Console.ReadLine());
		if (select==5) break;
				
                Console.Clear();
                Console.Write("Num1: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nNum2: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Clear();
                switch (select)
                {
                    case 1:
                        add(num1, num2);
                        if (back())
                        {
                            continue;
                        }
                        break;   
                    case 2:
                        sub(num1, num2);
                        if (back())
                        {
                            continue;
                        }
                        break;
                    case 3:
                        mul(num1, num2);
                        if (back())
                        {
                            continue;
                        }
                        break;
                    case 4:
                        div(num1, num2);
                        if (back())
                        {
                            continue;
                        }
                        break;
                }
            }
        }
    }
}
