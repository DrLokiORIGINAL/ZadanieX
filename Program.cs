using System;

namespace ZadanieX
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 1;
            //-------------------------------------------------------------
            double k = 999.01;
            //-------------------------------------------------------------
            var s = 10;
            //-------------------------------------------------------------
            Console.WriteLine($"{h} {k} {s}");
            //-------------------------------------------------------------
            h = h * h;
            Console.WriteLine(h);
            //-------------------------------------------------------------
            Console.WriteLine(12 % 4);
            //-------------------------------------------------------------
            Console.WriteLine("Введите переменные a, b, c");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a * b * c);
            Console.ReadKey();
            //-------------------------------------------------------------
            Console.WriteLine("Введите два числа: ");
            double i = Convert.ToDouble(Console.ReadLine());
            double o = Convert.ToDouble(Console.ReadLine());
            if (i>o)
            {
                Console.WriteLine("{0} Наибольшее число", i);
            }
            else
            {
                Console.WriteLine("{0} Наибольшее число", o);
            }
            Console.ReadLine();
            //-------------------------------------------------------------

        }
    }
}
