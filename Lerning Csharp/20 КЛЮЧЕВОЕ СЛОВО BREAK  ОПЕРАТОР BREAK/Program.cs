﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_КЛЮЧЕВОЕ_СЛОВО_BREAK__ОПЕРАТОР_BREAK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i =1; i<=100; i++)
            {
                Console.WriteLine(i);
                if (i == 10)
                    { 
                    break;
                }
                
            }
        }
    }
}
