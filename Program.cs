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
            //-------------------------------------------------------------
            Console.WriteLine("Введите два числа: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());
            if (n % 2 == 0 && m % 2 == 0)
            {
                Console.WriteLine(n + m);
            }
            else
            {
                Console.WriteLine(n * m);
            }
            //-------------------------------------------------------------
            int[] array = new int[5];
            //-------------------------------------------------------------
            for (int y = 0; y < array.Length; y++)
            {
                array[y] = int.Parse(Console.ReadLine());
            }
        }
    }
}
