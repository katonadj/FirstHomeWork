using System;

namespace Nemprim
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Nem prímek
            * Bekér a felhasználótól egy pozitív egész számot és kiírja az összes ennél kisebb olyan egész számot, amely nem prím
            */
            Console.WriteLine("Kérek egy pozitív egész számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = szam-1; i > 1; i--)
            {
                bool vanoszto = false;
                for (int j = 2; j < i / 2; j++)//1 et és önmagat kihagyom
                {
                    if (i % j == 0)
                    {
                        vanoszto = true;
                        break; //megszakítás, kilép a ciklusból
                    }
                }
                if (vanoszto)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
