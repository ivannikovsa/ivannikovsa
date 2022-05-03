using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            ConsoleKey oper = Console.ReadKey().Key;
            switch (oper)
            {
                case ConsoleKey.Add: Console.WriteLine(a + b);
                    break;
                case ConsoleKey.Subtract: Console.WriteLine(a - b);
                    break;
                case ConsoleKey.Multiply: Console.WriteLine(a * b);
                    break;
                case ConsoleKey.Divide: Console.WriteLine(a / b);
                    break;




                default:
                    Console.WriteLine("Что то");
                    break;
            }
        }
    }
}
