// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.WriteLine("Digite o valor de A: ");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Digite o valor de B: ");
int b = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Digite o valor de C: ");
int c = Convert.ToInt32(Console.ReadLine());

double delta = b * b - 4 * a * c;

if(delta < 0)
{
    Console.WriteLine("Não existem raízes reais");
} else if(delta == 0)
{
    Console.WriteLine("Existe apenas uma raiz real");
    double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double a2 = a1;
} else
{
    Console.WriteLine("Existe duas raizes reais");
    double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine($"A primeira raíz é {a1}, e a segunda é {a2}");
}
