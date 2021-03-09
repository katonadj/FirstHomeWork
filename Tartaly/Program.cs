using System;

namespace Tartaly
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;//Konstans
            const int doboz = 2;
            double atmero,magassag,sugar, terulet;
            int dobozdb;
            Console.Write("A tarály átmérő: ");
            atmero = Convert.ToDouble(Console.ReadLine());
            Console.Write("A tarály magasság: ");
            magassag = Convert.ToDouble(Console.ReadLine());
            sugar = atmero / 2;
            terulet = 2*(sugar * sugar * pi) +(2*sugar*pi*magassag);
            if (terulet % doboz == 0 )
            {
                dobozdb = Convert.ToInt32( terulet / doboz);
            }
            else
            {
                dobozdb = Convert.ToInt32(terulet / doboz) + 1;
            }
            Console.WriteLine($"A tartály területe: {terulet:0.00} m2");
            Console.WriteLine($" {dobozdb} festékesdoboz szükséges");

            Console.ReadKey();
        }
    }
}
