using System;

namespace ATV12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int zw = 0;
            double maior = 0, media = 0, menor = 0;
            double[] valores = new double[5];

            Console.WriteLine(" Exercicio para  calcula a média dos valores");
            Console.Write(" Digite os números ");
            zw = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < zw; i++) ;
            {
                Console.Write(" Digite um número:");
                valores[i] = Convert.ToDouble(Console.ReadLine());
            }
            i = 0;
            if (zw > 0)
            {
                maior = valores[0];
                menor = valores[0];
                media = valores[0];
                for (i = 1; i < zw; i++)
                {
                    if (maior < valores[i])
                    {
                        maior = valores[i];
                    }
                    if (menor < valores[i])
                    {

                        menor = valores[i];
                    }
                    else
                    {
                        Console.WriteLine(" Maior Valor: " + maior);
                        Console.WriteLine(" Maior Valor: " + media);
                        Console.WriteLine(" Maior Valor: " + menor);
                    }
                }
            }
        }
    }
}