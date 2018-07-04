using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double c;
            Console.WriteLine("Введите первое число");
            double a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите действие");
            string action = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            double b = Int32.Parse(Console.ReadLine());
            switch (action)
            {
                case "+":
                    Console.Write(a + " + " + b + " = ");
                    a = a + b;
                    Console.Write(a);
                    break;
                case "-":
                    Console.Write(a + " - " + b + " = ");
                    a = a - b;
                    Console.Write(a);
                    break;
                case "/":
                    if (b != 0)
                    {
                        Console.Write(a + " / " + b + " = ");
                        c = a / b;
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write("Деление на ноль");
                    }
                    break;
                case "*":
                    Console.Write(a + " * " + b + " = ");
                    a = a * b;
                    Console.Write(a);
                    break;
                case "%":
                    Console.Write(a + " % " + b + " = ");
                    a = a % b;
                    Console.Write(a);
                    break;
                default:
                    Console.WriteLine("Действие неизвестно");
                    break;
            }
        }
    }
}