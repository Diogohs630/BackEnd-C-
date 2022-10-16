using System;
using System.Globalization;

namespace BEE1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 60, Y = 90;
            Y = int.Parse(Console.ReadLine());

            int Tempo;
            Tempo = Y * 2;
            Console.WriteLine(Tempo + " minutos");

            Console.ReadLine();

        }
    }
}