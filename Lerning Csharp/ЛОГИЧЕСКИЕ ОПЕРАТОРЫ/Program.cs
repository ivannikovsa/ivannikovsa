using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛОГИЧЕСКИЕ_ОПЕРАТОРЫ
{
    internal class Program
    {
        public static bool Get1()
            { 
                return true; 
            }

        public static bool Get2()
        {
            return false;
        }
        static void Main(string[] args)
        {
           
            if(Get1() | Get2())
            {
                Console.WriteLine("Alarm");
            }
        }
    }
}
