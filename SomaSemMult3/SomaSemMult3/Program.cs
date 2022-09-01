using System;

namespace SomaSemMult3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroInicial = 1;
            var numeroFinal = 100;
            var soma = 0;

            for (int numeroAtual = numeroInicial; numeroAtual <= numeroFinal; numeroAtual++)
            {
                var ehMultiploDeTres = numeroAtual % 3 == 0;
                if (ehMultiploDeTres)
                    continue;

                soma += numeroAtual;
            }
            Console.WriteLine("Soma: " + soma);
        }
    }
}
