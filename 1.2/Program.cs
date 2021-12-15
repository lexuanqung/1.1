using System;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("so cua a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("so cua b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("so cua c: ");
            int c = int.Parse(Console.ReadLine());

            int delta = b * b - 4 * a * c;
            Console.WriteLine("{0}x2 + {1}x + {2}", a, b, c);
            if (a == 0)
            {
                float y = (-c) / b;
                Console.WriteLine("1 nghiem y = " + y);
            }
            else
            {
                if (delta > 0)
                {
                    Console.WriteLine("2 ngiem pb");
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2);
                }
                else if (delta == 0)
                {
                    Console.WriteLine("nghiem kep ");
                    float x = (float)((-b) / (a * 2));
                    Console.WriteLine("x1 = x2 = " + x);
                }
                else Console.WriteLine("vo nghiem");
            }
            Console.ReadKey();
        }
    }
}
