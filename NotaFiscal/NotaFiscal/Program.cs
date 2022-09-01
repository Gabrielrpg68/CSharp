using System;

namespace NotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de Nota Fiscal: ");
            double valorNotaFiscar = Convert.ToDouble(Console.ReadLine());
            double valorImposto;

            if (valorNotaFiscar <= 999)
            {
                valorImposto = valorNotaFiscar * 0.2;
            } else if (valorNotaFiscar > 999 && valorNotaFiscar <= 2999)
            {
                valorImposto = valorNotaFiscar * 2.5;
            } else if (valorNotaFiscar > 2999 && valorNotaFiscar <= 6999)
            {
                valorImposto = valorNotaFiscar * 2.8;
            }
            else
            {
                valorImposto = valorNotaFiscar * 3.0;
            }

            Console.WriteLine($"Valor do Imposto: {valorImposto}");
        }
    }
}
