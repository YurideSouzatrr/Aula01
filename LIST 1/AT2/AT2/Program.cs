using System;

namespace AT2
{
    class Program
    {
        static int Main(){ 
        {
       
                 int[] vetor = { 1, 0, 5, -2, -5, 7 };

                    int soma, i;

                    soma = vetor[0] + vetor[1] + vetor[5];
                    Console.WriteLine("Soma: %d\n\n", soma);


                    vetor[4] = 100;

                    for (i = 0; i < 6; i++)
                        Console.WriteLine("%d\n", vetor[i]);

                return 0;
            }
            }
        }
    }