using System;

namespace _1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          MENU          ");
            Console.WriteLine("=======================");
            Console.WriteLine("1. CF");
            Console.WriteLine("2. C");
            Console.WriteLine("3. HDJ");
            Console.WriteLine("4. DreamWeawer");
            Console.WriteLine("5. RDBMS");
            Console.WriteLine("6. Learn Java By Example");
            Console.WriteLine("=======================");
            Console.WriteLine("Chon: ");
            char chon = char.Parse(Console.ReadLine());
            switch (chon)
            {
                case '1':
                    Console.WriteLine("Ban chon la CF");
                    break;
                case '2':
                    Console.WriteLine("C");
                    break;
                case '3':
                    Console.WriteLine("Ban chon la DHJ");
                    break;
                case '4':
                    Console.WriteLine("Ban chon la DreamWeawer");
                    break;
                case '5':
                    Console.WriteLine("Ban chon la RDBMS");
                    break;
                case '6':
                    Console.WriteLine("Ban chon la Learn Java By Example");
                    break;
                default:
                    Console.WriteLine("ban da chon sai");
                    break;
            }

        }
    }
}
