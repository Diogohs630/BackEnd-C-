using System;
using System.Globalization;

namespace BEE1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendasTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorRecebido = ((vendasTotal / 100) * 15.0) + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + valorRecebido.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}