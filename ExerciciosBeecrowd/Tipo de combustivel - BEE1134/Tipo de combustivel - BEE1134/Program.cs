using System;
using System.Globalization;

namespace BEE1134
{
    class Program
    {
        static void Main(string[] args)
        {
            uint codCombustivel = uint.Parse(Console.ReadLine());
            int cod1 = 0, cod2 = 0, cod3 = 0;
            while ( codCombustivel != 4)
            {
                if (codCombustivel > 0 && codCombustivel <= 4)
                {
                    switch (codCombustivel)
                    {
                        case 1:
                            cod1++;
                            break;
                        case 2:
                            cod2++;
                            break;
                        case 3:
                            cod3++;
                            break;
                    }
                    codCombustivel = uint.Parse(Console.ReadLine());
                }
                else
                {
                    codCombustivel = uint.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + cod1);
            Console.WriteLine("Gasolina: " + cod2);
            Console.WriteLine("Diesel: " + cod3);
            Console.ReadLine();
        }
    }
}