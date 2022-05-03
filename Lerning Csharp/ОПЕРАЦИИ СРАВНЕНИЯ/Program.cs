using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОПЕРАЦИИ_СРАВНЕНИЯ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            bool res = a == b;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            
            Console.ReadLine();

        }
    }
}
