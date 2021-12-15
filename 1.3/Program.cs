using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.WriteLine("Canh thu 1: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Canh thu 2: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Canh thu 3: ");
            c = Convert.ToSingle(Console.ReadLine());


            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("day la tam giac");
            }
            else Console.WriteLine("day khong phai la tam giac");

        }
    }
}
