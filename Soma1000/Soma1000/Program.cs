using System;

namespace Soma1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                soma += i;
            }

            Console.WriteLine("Soma: " + soma);
        }
    }
}
