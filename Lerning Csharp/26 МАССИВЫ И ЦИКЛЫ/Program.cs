using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_МАССИВЫ_И_ЦИКЛЫ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = {10,684,984,32,469 };
            Console.WriteLine(myarr[0]);
            for (int i = 0; i < myarr.Length; i++)
            {
                Console.WriteLine(myarr[i]); 
            }
        }
    }
}
