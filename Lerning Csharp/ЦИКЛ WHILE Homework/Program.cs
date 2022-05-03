using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЦИКЛ_WHILE_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите начало диапазона");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона");
            int b = int.Parse(Console.ReadLine());
            
            while (a > b)
                Console.WriteLine("Начало диапазона меньше конца. Введите новые данные");
            
            int chet = 0;
            int nechet = 0;
            while (a<=b)
            {
                if (a%2==0)
                    chet++;
                else
                    nechet++;
                a++;
            }
            Console.WriteLine("Количество чётных чисел: "+chet+". Количество нечётных чисел: " + nechet+".");
            Console.ReadLine();
        }
    }
}
