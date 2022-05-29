using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace _22_Примеры_вложенных_массивов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scale = 20;
            string row;
            row = "";
            for (int i = 1; i <= scale; i++)
            {
                row = "";
                for (int j = 1; j <= i; j++)
                {
                    row = row + "#";
                }
                Console.WriteLine(row);
            }
            Console.WriteLine();
            for (int i = scale; i >= 0; i--)
            { 
                Console.WriteLine(row.Substring(0, i));
            }
            Console.WriteLine();
            for (int i = 0; i <= scale; i++)
            {
                row = "";
                for (int j = scale-i; j > 0; j--)
                {
                    row = row + " ";
                }
                for (int k = 1; k <= i; k++)
                {
                    row = row + "#";
                }
                Console.WriteLine(row);
            }
            Console.WriteLine();
            for (int i = 0; i <= scale; i++)
            {
                row = "";
                for (int j = i; j > 0; j--)
                {
                    row = row + " ";
                }
                for (int j = 1; j <= scale-i; j++)
                {
                    row = row + "#";
                }
                Console.WriteLine(row);
            }
        }
    }
}
