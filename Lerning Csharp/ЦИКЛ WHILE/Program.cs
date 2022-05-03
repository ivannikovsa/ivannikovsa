using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЦИКЛ_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = int.Parse(Console.ReadLine());
            while(a<=b)
                Console.WriteLine("Action" + a++);



        }
    }
}
