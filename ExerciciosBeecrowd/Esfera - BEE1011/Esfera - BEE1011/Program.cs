using System;
using System.Globalization;

namespace BEE1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, R;
            pi = 3.14159;
            
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volumeEsfera = (double)(4.0 / 3) * pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + volumeEsfera.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}