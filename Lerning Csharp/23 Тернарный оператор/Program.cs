using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Тернарный_оператор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data = int.Parse(Console.ReadLine());
            int qwe;
            qwe = data > 0 ? data : 0;
            Console.WriteLine(qwe);
        }
    }
}
