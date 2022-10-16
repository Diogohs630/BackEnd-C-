using System;
using System.Globalization;

namespace BEE1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            int Nota100 = N/100;
            int resto100 = N % 100;

            int Nota50 = resto100 / 50;
            int resto50 = resto100 % 50;

            int Nota20 = resto50 / 20;
            int resto20 = resto50 % 20;

            int Nota10 = resto20 / 10;
            int resto10 = resto20 % 10;

            int Nota5 = resto10 / 5;
            int resto5 = resto10 % 5;

            int Nota2 = resto5 / 2;
            int resto2 = resto5 % 2;

            int Nota1 = resto2 / 1;

            Console.WriteLine(N);
            Console.WriteLine(Nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(Nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(Nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(Nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(Nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(Nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(Nota1 + " nota(s) de R$ 1,00");

            Console.ReadLine();
        }
    }
}