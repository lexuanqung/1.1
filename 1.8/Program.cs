using System;

namespace _1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("nhap canh A(xA, yA): ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nhap canh b: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nhap canh c: ");
            c = Convert.ToSingle(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
            {
                // tam giac đều
                if (a == b || a == c || b == c)
                {
                    Console.WriteLine("ba canh tren la tam giac deu");
                }
                else if (a == b && a == c)
                {
                    // tam giac vuong can va can
                    if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))
                    {
                        Console.WriteLine("ba canh tren la tam giac vuong can");
                    }
                    else Console.WriteLine("Ba canh tren la tam giac can");
                }
                else if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))
                {
                    Console.WriteLine("Ba canh tren la tam giac vuong");
                }
                else Console.WriteLine("Ba canh tren la tam giac thuong");
            }
            else Console.WriteLine("Ba canh tren khong phai la ta giac");
        }
    }
}
