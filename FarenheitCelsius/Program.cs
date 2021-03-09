using System;

namespace FarenheitCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Farenheit-Celsius");
            double celsius;
            double fahrenheit;//kiszámoljuk
            Console.Write("Farenheit = ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());//A Console ReadLine Szöveges típust olvas be
            celsius = (fahrenheit -32) / 1.8;
            Console.WriteLine($"{fahrenheit:F2} °F = {celsius:F2} °C");
            Console.ReadKey();
        }
    }
}

