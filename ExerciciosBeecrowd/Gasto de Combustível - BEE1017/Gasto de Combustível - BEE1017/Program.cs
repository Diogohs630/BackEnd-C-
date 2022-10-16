using System;
using System.Globalization;

namespace BEE1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaConsumo = 12.00;
            int tempo = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());
            double QtdPorLitro = ((tempo * velocidadeMedia) / mediaConsumo);

            Console.WriteLine(QtdPorLitro.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}