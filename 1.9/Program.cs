using System;

namespace _1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            float xA, yA, xB, yB, xC, yC, xD, yD;
            Console.Write("Nhap toa do diem A(xA, yA): ");
            xA = Convert.ToSingle(Console.ReadLine());
            yA = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap toa do diem B(xB, yB): ");
            xB = Convert.ToSingle(Console.ReadLine());
            yB = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap toa do diem C(xC, yC): ");
            xC = Convert.ToSingle(Console.ReadLine());
            yC = Convert.ToSingle(Console.ReadLine());

            float xAB = (xB - xA), yAB = (yB - yA);
            float AB = (float)Math.Sqrt(xAB * xAB + yAB * yAB);
            float xAC = (xC - xA), yAC = (yC - yA);
            float AC = (float)Math.Sqrt(xAC * xAC + yAC * yAC);
            float xBC = (xC - xB), yBC = (yC - yB);
            float BC = (float)Math.Sqrt(xBC * xBC + yBC * yBC);

            if ((xAB / xAC) != (yAB / yAC))
            {
                // tam giac deu
                if (AB == BC || AB == AC || BC == AC)
                {
                    Console.WriteLine("Ba diem tren la tam giac deu");
                    // TAM GIAC VUONG CAN VA CAN
                }
                else if (AB == BC && AB == AC)
                {
                    if ((AB * AB + BC * BC == AC * AC) || (BC * BC + AC * AC == AB * AB) || (AB * AB + AC * AC == BC * BC))
                    {
                        Console.WriteLine("Ba diem tren la tam giac vuong can");
                    }
                    else Console.WriteLine("Ba diem tren la tam giac can");
                    // tam giac vuong

                }
                else if ((AB * AB + BC * BC == AC * AC) || (BC * BC + AC * AC == AB * AB) || (AB * AB + AC * AC == BC * BC))
                {
                    if (AB * AC == 0)
                    {
                        Console.WriteLine("Ba diem tren la tam giac vuong tai A");
                    }
                    else if (AB * BC == 0)
                    {
                        Console.WriteLine("Ba diem tren la tam giac vuong tai B");
                    }
                    else if (BC * AC == 0)
                    {
                        Console.WriteLine("Ba diem tren la tam giac vuong tai C");
                    }
                }
                else Console.WriteLine("ba diem tren la tam giac thuong");

                Console.Write("Nhap toa do diem D(xD, yD): ");
                xD = Convert.ToSingle(Console.ReadLine());
                yD = Convert.ToSingle(Console.ReadLine());
                float ba = (float)((xD - xA) / (xB - xA) - (yD - yA) / (yB - yA));
                float cb = (float)((xD - xB) / (xC - xB) - (yD - yB) / (yC - yB));
                float ac = (float)((xD - xC) / (xA - xC) - (yD - yC) / (yA - yC));
                float tich = (float)(ba * cb * ac);
                if (tich < 0)
                {
                    Console.WriteLine("Diem D(xD, yD) nam trong tam giac ABC");
                }
                else Console.WriteLine("Diem D(xD, yD) khong nam trong tam gac ABC");

            }
            else Console.WriteLine("Ba toa do tren khong phai la tam giac");

        }
    }
}
