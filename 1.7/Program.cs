using System;

namespace _1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            onsole.WriteLine("Nhap so thu nhat: 6 ");
            Console.WriteLine("Nhap so thu hai: 5 ");
            Console.WriteLine("        MENU        ");
            Console.WriteLine("====================");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine(":");
            Console.WriteLine("====================");
            Console.WriteLine("Chon: ");
            char c = char.Parse(Console.ReadLine());
            int a = 6;
            int b = 5;
            switch (c)
            {
                case '+':
                    Console.WriteLine("{0} + {1}= {2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1}= {2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1}= {2}", a, b, a * b);
                    break;
                case ':':
                    Console.WriteLine("{0} : {1}= {2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Nguoi dung nhap sai phep toan");
                    break;
            }
            Console.ReadKey();

        }
    }
}
