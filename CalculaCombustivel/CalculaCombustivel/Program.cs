// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Double gas;
Double eta;

Console.WriteLine("Valor da Gasolina: ");
gas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Valor do Etanol: ");
eta = Convert.ToDouble(Console.ReadLine());

double valorMaximo = gas - gas * 0.3;

if (valorMaximo < eta)
{
    Console.WriteLine("Coloca Gasolina");
}
else
{
    Console.WriteLine("Coloca Etanol");
}

