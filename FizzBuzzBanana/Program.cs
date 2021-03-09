using System;

namespace FizzBuzzBanana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alsó határ: ");
            int also = Convert.ToInt32(Console.ReadLine());
            Console.Write("Felső határ: ");
            int felso = Convert.ToInt32(Console.ReadLine());
            if (also > felso)
            {
                int temp = also;
                also = felso;
                felso = temp;
            }

            for (int i = also; i <= felso; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("banana");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
