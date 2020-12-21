using System;

namespace ATV13
{
    class Program
    {
        static void Main(string[] args)
        {
            
      Console.WriteLine(" Posição é o maior e o menor valor.");
   

            int[] vetor = new int[10];

            Random numAleatorio = new Random();


            for (int i = 0; i < vetor.Length; i++)
            {
                int valorNum = numAleatorio.Next(1, 11);
                vetor[i] = valorNum;

            }

            Console.Write("Lista de Números:");
            foreach (int numero in vetor)
            {
                Console.Write(numero + "-");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Menor Número: ");
            Array.Sort(vetor);
            Console.WriteLine(vetor[0]);
            Console.Write("Maior Número: ");
            Array.Reverse(vetor);
            Console.WriteLine(vetor[0]);
        }
    }
}
