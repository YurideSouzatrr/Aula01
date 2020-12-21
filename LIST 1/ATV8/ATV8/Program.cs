using System;

namespace ATV8
{

    class Program
    {

        static void ExibindoValores(int[] v, int tl)

        {
            Console.WriteLine(" Valores dentro do Vetor:");
            for (int i = 0; i < tl; i++)
            {
                Console.Write(v[i] + ", ");
            }
            Console.Write("");
        }
        static void InvertendoOsValores(int[] vet, int tl)
        {
            int j = tl - 1;
            int i = 0;
            int aux = 0;
            while (i < j)
            {
                aux = vet[i];
                vet[i] = vet[j];
                vet[j] = aux;
                j--;
                i++;
            }
        }
    static void Main(string[] args)
        {
            int[] vet = new int[30];
            int tl = 10, i, j, aux;
            for (i = 0; i < 10; i++)
            {
                vet[i] = (i + 1) * 10;
            }
            ExibindoValores(vet, tl);
            InvertendoOsValores(vet, tl);
            j = tl - 1;
            i = 0;
            while (i < j)
            {
                aux = vet[i];
                vet[i] = vet[j];
                vet[j] = aux;
                j--;
                i++;

            }
            ExibindoValores(vet, tl);
            InvertendoOsValores(vet, tl);
            Console.ReadKey();
        }
    }

}