using System;


namespace ForsEncadeados
{   
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int r;
            for (int i = 1; i <= 4; i++)
            {
                String[] numeros = new String[i];
                for (int index = 0; index < i; index++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        r = i * j;
                        numeros[j-1] = Convert.ToString(r);

                    }
                    
                }
                Console.WriteLine(String.Join(" ", numeros));

            }
        }   
    }   
}
