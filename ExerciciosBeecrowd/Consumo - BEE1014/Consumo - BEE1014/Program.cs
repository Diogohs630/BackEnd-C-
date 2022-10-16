using System;
using System.Globalization;

namespace BEE1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine((X / Y).ToString("F3", CultureInfo.InvariantCulture) + " km/l");

            Console.ReadLine();

        }
    }
}