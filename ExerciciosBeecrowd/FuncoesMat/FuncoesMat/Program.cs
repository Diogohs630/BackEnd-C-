using System;
using System.Globalization;

namespace FuncoesMat
{
    class program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("Raiz quadrada de " + z + " = " + C);

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("O valor absoluto de " + x + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);

            /* Formula Bhaskara
            double delta;
            double x1, x2;

            delta = Math.Pow(B, 2.0) - 4 * A * C;
            x1 = (-B + Math.Sqrt(delta)) / (2.0 * A) ;
            x2 = (-B - Math.Sqrt(delta) / (2.0 * A));
            Console.WriteLine(x1);
            */
        }
    }
}
