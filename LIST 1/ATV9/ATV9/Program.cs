using System;

namespace ATV9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[6];
            int pares = 0;
            double total = 0;
            int tl = 6, c, r, aux;

            Console.WriteLine();
            Console.WriteLine("  Números Pares ");

            Console.WriteLine("  Digite Os Números ");
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + "º número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    total = total + 1;
                }
                c = tl - 1;
                i = 0;
                while (i < c)
                {
                    aux = a1[i];
                    a1[c] = a1[r];
                    a1[r] = aux;
                    c--;
                    i++;

                    Console.WriteLine("Total de números pares = " + total);

                }
            }
        }
    }
}