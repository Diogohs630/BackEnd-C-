using System;
using System.Globalization;

namespace Avalizacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(" ");
            int codPrd, Qtd;
            codPrd = int.Parse(vet[0]);
            Qtd = int.Parse(vet[1]);

            double vTotal = 0;
            switch (codPrd)
            {
                case 1:
                    vTotal = Qtd * 4.00;
                    break;
                case 2:
                    vTotal = Qtd * 4.50;
                    break;
                case 3:
                    vTotal = Qtd * 5.00;
                    break;
                case 4:
                    vTotal = Qtd * 2.00;
                    break;
                case 5:
                    vTotal = Qtd * 1.50;
                    break;
            }

            Console.WriteLine("Total: R$ " + vTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}