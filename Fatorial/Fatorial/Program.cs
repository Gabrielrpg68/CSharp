using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, numero, fatorial;
            Console.WriteLine("Informe o número");
            numero = double.Parse(Console.ReadLine());

            fatorial = numero;
            for (i = numero - 1; i >= 1; i--)
            {

                fatorial = fatorial * i;

                Console.WriteLine("i= " + i);
                Console.WriteLine("fatorial= " + fatorial);
                Console.WriteLine("  ");
            }
            Console.WriteLine("\nFatorial de " + numero + " é " + fatorial);
            Console.ReadLine();
        }
    }
}
