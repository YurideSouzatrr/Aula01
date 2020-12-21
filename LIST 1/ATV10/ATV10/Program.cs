using System;

namespace ATV10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] notas = new int[15];
            int media;

            for (i = 0; i < 15; i++)
            {
                Console.Write("Digite a nota do aluno : ", i + 1);
                Console.WriteLine("%f", notas[i]);

                int v = notas[i];
                media + = v;
            
            }
            Console.WriteLine("A media geral é: %.1f", media / 15.0);
        }
            return 0;
        }
    }
