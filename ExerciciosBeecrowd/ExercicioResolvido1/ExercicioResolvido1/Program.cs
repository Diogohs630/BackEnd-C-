using System;
using System.Globalization;

namespace Exercicio1{
    class program{
        static void Main(string[] args){
            double L = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ValorM = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Area = L * C;
            double Preco = ValorM * Area;

            Console.WriteLine("AREA = " + Area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + Preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
