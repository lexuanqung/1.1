using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nghiem A = ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("nghiem B = ");
            int B = int.Parse(Console.ReadLine());

            if (B == 0)
            {
                Console.WriteLine("Error: divide by zero");

            }
            else
            {
                float C = (float)(A / B);
                Console.WriteLine("so C = A/B = " + C);
            }
            Console.ReadKey();
        }
    }
}
