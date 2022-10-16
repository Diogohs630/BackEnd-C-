using System;
using System.Globalization;

namespace BEE1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double vlr1 = 0.0, vlr2 = 0.0, vlr3 = 0.0;
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                vlr1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                vlr2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                vlr3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = (vlr1 * 2.0 + vlr2 * 3.0 + vlr3 * 5.0) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}