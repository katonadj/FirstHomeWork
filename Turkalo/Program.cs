using System;

namespace Turkalo
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Turkáló
            *Egy turkálóban minden póló darabja 500 Ft. Ha egy vásárlás során valaki több darabot is vesz, a második ára már csak 450 Ft, a harmadik pedig 400 Ft, de a negyedik és további darabok is ennyibe kerülnek, tehát az ár a harmadik vásárlása után már nem csökken tovább.
            *Írj programot, amely a vásárolt pólók darabszámának ismeretében megmondja, hogy mennyit fizet a vásárló!
            */ 
            Console.WriteLine("Üdvözöljük a turkáló programban!");
            Console.Write("Kérem adja meg hány db polót vásárolt:");
            int darab = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int osszeg = darab * 500;
                   
                for (int i = 1; i < darab ; i++)
                {
                    if (i<2)
                    {
                        osszeg = osszeg - 50;
                    }

                    if (i>=2)
                    {
                        osszeg = osszeg - 100;
                    }
                }
            
                Console.WriteLine("Fizetendő: {0} Ft", osszeg); 
            
            Console.ReadKey();
        }
    }
}
