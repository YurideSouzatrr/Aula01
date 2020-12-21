using System;

namespace ATV6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int tl = 0;
            double maior = 0, menor = 0;
            double[] valores = new double[100];

            Console.WriteLine(" Média dos Valores Digitados");
            Console.Write(" Números informados:");
            tl = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < tl; i++)
            {
                Console.Write(" Digite um numero: ");
                valores[i] = Convert.ToDouble(Console.ReadLine());
            }
            i = 0;
            if (tl > 0)
            {
                maior = valores[0];
                menor = valores[0];
                
                for (i = 1; i < tl; i++)
                {
                    if (maior < valores[i])
                    {
                        maior = valores[i];
                    }
                    if (menor > valores[i])
                    {
                        menor = valores[i];
                    }
                    else
                    {
                        Console.WriteLine("Nenhum Valor foi informado");
                    }
                    Console.WriteLine(" Maior Valor: " + maior);
                    Console.WriteLine(" Menor Valor: " + menor);
                    Console.ReadKey();
                }
            }
        }
    }
}