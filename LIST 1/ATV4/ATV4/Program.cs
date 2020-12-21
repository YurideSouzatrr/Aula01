using System;

namespace ATV4
{
    class Program
    {
        static void Main() { 
        {
 
                int[] vet=new int [8];
                int x;
                int i;
                int a;
                int soma;
                for (i = 1; i <= 11; i++)
                {
                    Console.WriteLine("%d", vet[i]);
                }


                Console.WriteLine("%d",x);

                vet[0] = x;

                Console.WriteLine("%d",a);

                vet[11] = a;

                soma = vet[0] + vet[11];

            Console.WriteLine("\n A soma \x86: %d", soma);
                Console.ReadKey();
            }
        }
    }
}
