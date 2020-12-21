using System;

namespace ATV5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];
            int npar = 0;
            Console.WriteLine(" Lendo o Vetor");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Vetor[" + i + "]:");
                v1[i] = Convert.ToInt32(Console.ReadLine());

            }
            // numeros pares 
            for (int i = 0; i < 10; i++)
            {
                if (v1[i] % 2 == 0)
                {
                    npar++;
                }
            }
            
                    Console.WriteLine(" Total de Números Pares: "+npar);
                    Console.ReadKey();
                }
            }
        }



