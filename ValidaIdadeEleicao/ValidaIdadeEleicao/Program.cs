// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nacionalidade: ");
bool brasileiro = Convert.ToBoolean(Console.ReadLine().ToLower());

if ( idade > 15 && brasileiro == true)
{
    Console.WriteLine("Esta apta a votar");
}
else
{
    Console.WriteLine("Não pode voltar");
}
