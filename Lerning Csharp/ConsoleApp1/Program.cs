using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //static void Main(string[] args)
        //{

        //    string var1 = "2,4";
        //    NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        //    {
        //        NumberDecimalSeparator = ",",


        //    };


        //    double a = Convert.ToDouble(var1, numberFormatInfo);


        //}


        //static void Main(string[] args)
        //{//lesson 7
        //    string str = "5";

        //    int a;

        //    bool resultion = int.TryParse(str, out a);

        //    if (resultion)
        //    {
        //        Console.WriteLine(a);

        //    }
        //    else
        //    {
        //        Console.WriteLine("Ошибка");

        //    }

        //}


        //static void Main(string[] args)
        //{//консоль не закрывайся
        //Console.WriteLine("Console please don`t close");
        //Console.Read();



        //}
        //static void Main(string[] args)
        //{//lesson 8
        //    int a = 10;
        //    int b = 3;
        //    int c = 4;
        //    int res =  a + b+c;
        //    Console.WriteLine(res);
        //    Console.Read();


        //}

        static void Main(string[] args)
        {//lesson 8 homework
            Console.WriteLine("Введите два числа и получите среднее");
            double firstValue, secondValue;
            firstValue = double.Parse(Console.ReadLine());
            secondValue = double.Parse(Console.ReadLine());
            double res = (firstValue + secondValue) / 2;
            Console.WriteLine(res);

            Console.WriteLine("Введите три числа");
            string num3 = Console.ReadLine();
            string num4 = Console.ReadLine();
            string num5 = Console.ReadLine();
            int res2 = int.Parse(num3) + int.Parse(num4) + int.Parse(num5);
            Console.WriteLine(res2);

            Console.WriteLine("Введите валюту (долл/евро)");
            string currency = Console.ReadLine();
            Console.WriteLine("Введите количество");
            string value = Console.ReadLine();
            if (currency == "долл")
            {
                int res3 = int.Parse(value) * 32;
                Console.WriteLine(value + " " + currency + " = " + res3 + "руб");

            }
            else
            {
                int res3 = int.Parse(value) * 35;
                Console.WriteLine(value + " " + currency + " = " + res3 + "руб");
            }





            //    Console.Read();


            //}

        //    static void Main(string[] args)
        //{//lesson 9
        //    int val = (2 + 2) * 2;
        //    Console.WriteLine(val);
        //    Console.ReadLine();


        //}


    }
}
