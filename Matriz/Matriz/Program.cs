using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Fazer um programa para ler um número inteiro N e uma matriz de ordem N (uma
            //matriz quadrada, com a quantidade igual entre linhas e colunas) contendo
            //números inteiros.Em seguida, mostrar a diagonal principal e a quantidade de
           //valores negativos da matriz.


            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int o = 0; o < n; o++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[o, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine(" A Diagonal é  ");
            for (int o = 0; o < n; o++)
            {
                Console.Write(mat[o, o] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int o = 0; o < n; o++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[o, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(" Números Negativos " + count);

        }
    }
}