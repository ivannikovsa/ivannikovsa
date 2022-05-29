using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ВЛОЖЕННЫЕ_ЦИКЛЫ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Cicle 1 iteration #" + i);
                for (int j = 1; j < 6; j++)
                {
                    Console.WriteLine("\tCicle 2 iteration #" + j);
                    for (int k = 1; k < 3; k++)
                    {
                        Console.WriteLine("\t\tCicle 3 iteration #" + k);
                    }
                }
            }
        }
    }
}
