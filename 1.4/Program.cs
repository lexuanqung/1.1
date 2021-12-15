using System;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tinh km taxi: ");
            float km = float.Parse(Console.ReadLine());

            if (km <= 1)
            {
                float tong = km * 15000;
                Console.WriteLine("Km {0},tong tien la {1} ", km, tong);
            }
            else if (km <= 5)
            {
                float tong = (1 * 15000) + ((km - 1) * 13500);
                Console.WriteLine("Km {0},tong tien la {1} ", km, tong);
            }
            else if (km > 5)
            {
                float tong = (1 * 15000) + (4 * 13500) + ((km - 5) * 11000);
                Console.WriteLine("km {0},tong tien la {1} ", km, tong);
            }
            else if (km > 120)
            {
                float tong = (float)((1 * 15000) + (4 * 13500) + ((km - 5) * 11000)) * 0.9f;
                Console.WriteLine("Km {0}, tong tien la {1}", km, tong);
            }
            Console.ReadKey();


        }
    }
}
