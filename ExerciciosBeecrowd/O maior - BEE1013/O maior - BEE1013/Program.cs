using System;
using System.Globalization;

namespace BEE1013
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            String line1 = Console.ReadLine();
            String[] vet = line1.Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            int MaiorAB = (int) ((a + b) + (Math.Abs(a - b))) / 2;
            int maiotC = (int) ((MaiorAB + c) + (Math.Abs(MaiorAB - c)))/2;

            Console.WriteLine(maiotC + " eh o maior");
            Console.ReadLine();
        }
    }
}