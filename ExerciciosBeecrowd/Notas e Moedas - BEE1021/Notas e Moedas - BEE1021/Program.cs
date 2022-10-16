using System;
using System.Globalization;

namespace _21_Notas_e_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, cem, cinquenta, vinte, dez, cinco, dois, um_r, cinquenta_c, vintec_c, dez_c, cinco_c, um_c, resto;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //NOTAS
            cem = N / 100;
            resto = N % 100;
           
            cinquenta = resto / 50;
            resto = resto % 50;
            
            vinte = resto / 20;
            resto = resto % 20;
            
            dez = resto / 10;
            resto = resto % 10;
           
            cinco = resto / 5;
            resto = resto % 5;
            
            dois = resto / 2;
            resto = resto % 2;
            
            //MOEDAS
            um_r = resto / 1;
            resto = resto % 1;
            
            resto = resto * 100.0;
            cinquenta_c = resto / 50;
            resto = resto % 50;
            
            vintec_c = resto / 25;
            resto = resto % 25;
            
            dez_c = resto / 10;
            resto = resto % 10;
            
            cinco_c = resto / 5;
            resto = resto % 5;
            
            um_c = resto / 1;
            resto = resto % 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine((int)cem + " nota(s) de R$ 100.00");
            Console.WriteLine((int)cinquenta + " nota(s) de R$ 50.00");
            Console.WriteLine((int)vinte + " nota(s) de R$ 20.00");
            Console.WriteLine((int)dez + " nota(s) de R$ 10.00");
            Console.WriteLine((int)cinco + " nota(s) de R$ 5.00");
            Console.WriteLine((int)dois + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine((int)um_r + " moeda(s) de R$ 1.00");
            Console.WriteLine((int)cinquenta_c + " moeda(s) de R$ 0.50");
            Console.WriteLine((int)vintec_c + " moeda(s) de R$ 0.25");
            Console.WriteLine((int)dez_c + " moeda(s) de R$ 0.10");
            Console.WriteLine((int)cinco_c + " moeda(s) de R$ 0.05");
            Console.WriteLine((int)um_c + " moeda(s) de R$ 0.01");
            Console.ReadLine();
        }
    }
}