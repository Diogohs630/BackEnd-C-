using System;

namespace BEE1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int[] numeros = new int[3];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(vet[i]);
            }
            Array.Sort(numeros);
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadLine();
        }
    }
}