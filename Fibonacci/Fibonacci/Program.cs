using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequencia de Fibonacci");

                int num1 = 0, num2 = 0, aux;

                while(num2< 100)
                {   
                    if(num2 < 1)
                    {
                        num2 += 1;
                        Console.WriteLine("{0}", num2);
                }
                    else {
                        aux = num1;
                        num1 = num2;
                        num2 = num1 + aux;
                        Console.WriteLine("{0}", num2);
                    }
                    

                }


        }

        
    }
}
