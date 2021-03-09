using System;

namespace TokeletesSzam
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Tökéletes szám
		     *       Bekér a felhasználótól egy pozitív egész számot és kiírja, hogy tökéletes szám-e.
			 *       Tökéletes az a szám, amely megegyezik osztóinak összegével.
			 *	        például: 28 = 1 + 2 + 4 + 7 + 14
             */
            Console.Write("Kérem adjon meg egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int osszeg = 0;
            Console.Write("SZUM(");
            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg = i + osszeg;
                    Console.Write("{0} ",i);
                }    
            }
            Console.Write(") =>");
            Console.WriteLine(osszeg);
            if (osszeg == szam)
            {
                Console.WriteLine("{0} -> Ez bizony egy tökéletes szám!",szam);
            }
            else
            {
                Console.WriteLine("{0} -> Ez sajnos nem tökéletes szám!", szam);
            }
            Console.ReadKey();
        }
    }
}
