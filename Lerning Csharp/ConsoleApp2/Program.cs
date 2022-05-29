using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenth");
            int dlina = int.Parse(Console.ReadLine()), last_step = dlina - 1;
            string long_row = "", short_row = "";

            for (int i = 1; i <= dlina; i++)
            {
                long_row = long_row + "-";
            }

            for (int i = 1; i <= dlina; i++)
            {
                if (i==1)
                {
                    short_row = "|";
                }
                else if (i==dlina)
                {
                    short_row = short_row + "|";
                }
                else
                    short_row = short_row + "#";
             
            }
            
            for (int i = 1; i <= dlina; i++)
            {
                if (i == 1 || i == dlina)
                {
                    Console.WriteLine(long_row);
                }
                else { Console.WriteLine(short_row); }
            }
        }
    }
}
