using System;

namespace _1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ki tu la: ");
            char kitu = char.Parse(Console.ReadLine());

            if ((kitu >= 'a' && kitu <= 'z') || (kitu >= 'A' && kitu <= 'Z'))
            {
                Console.WriteLine("ki tu vua nhap thuoc bang chu cai");
                if (kitu == 'A' && kitu == 'U' && kitu == 'I' && kitu == 'O' && kitu == 'E' && kitu == 'a' && kitu == 'u' && kitu == 'i' && kitu == 'o' && kitu == 'e')
                {
                    Console.WriteLine(kitu + " la nguyen am");
                }
                else Console.WriteLine(kitu + " la phu am");
            }
            else Console.WriteLine("ki tu vua nhap khong thuoc bang chu cai");
            Console.ReadKey();

        }
    }
}
