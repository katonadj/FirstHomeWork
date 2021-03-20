using System;

namespace Tombos
{
    class Program
    {
/*
 * Adott egy valós számokat tartalmazó tömb, benne vegyesen mindenféle előjelű számokkal.
 * Írj egy olyan programot, amelyik kilistázza a tömböt az elemek indexeivel! (Emlékezz vissza, ezt a feladatot egyszer már megoldottad laboron.) Valahogy így:
 * Összesen 10 szám van.
 * [0]= 2.5[1] = -69[2] = 5.4[3] = -8[4] = -7.7[5] = 6[6] = 2.9[7] = -10[8] = -3[9] = 9.8
 * A következő lépés kigyűjteni egy másik tömbbe a negatív tömbelemek indexeit.Listázd ki ezeket az indexeket is!
 * Ebből 5 szám negatív.
 * Indexeik: 1 3 4 7 8
 * Ha ez is megvan, egy olyan programrészt kell írnod, amelyik az indexek ismeretében kiírja, hogy mik voltak a negatív számok. Fontos, hogy ne keresd meg újra a negatív számokat! Elvégre is, ha az indexeik megvannak, abból már lehet tudni, melyek voltak azok.A végleges eredmény valami ilyesmi legyen:
 * Összesen 10 szám van.
 * [0]= 2.5[1] = -69[2] = 5.4[3] = -8[4] = -7.7[5] = 6[6] = 2.9[7] = -10[8] = -3[9] = 9.8
 * Ebből 5 szám negatív.
 * [1]= -69[3] = -8[4] = -7.7[7] = -10[8] = -3
*/
        static void Main(string[] args)
        {
            int[] szamok = { 10, -4, 6, -3, 87, 2, -56, 69, -1, 54, 87, 34 };
            int[] negindex = new int[szamok.Length];
            int negcount = 0;
            Console.WriteLine("Összesen {0} db számot tartalmaz a tömb:",szamok.Length);
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<0)
                {
                    negindex[i] = i;
                    negcount++;
                }
                else
                {
                    negindex[i] = -1;
                }
                Console.Write("[{0}] = {1} ",i,szamok[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Összesen {0} negatív számot tartalmaz a tömb: ",negcount);
            //foreach (var item in negindex)
            //{
            //    if (item != -1)
            //    {
            //        Console.Write("{0} ", item);
            //    }
            //}
            //Console.WriteLine();
            for (int i = 0; i < negindex.Length; i++)
            {
                if (negindex[i] != -1)
                {
                    Console.Write($"[{i}] = {szamok[i]} "); 
                }
            }

            Console.ReadLine();

        }
    }
}
