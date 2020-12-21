using System;

namespace ATV5
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                int carrosVendidos;
                string ler;
                double comissao = 300.00, vlrComissao, salarioFixo = 800.00, salarioTotal;

                Console.Write("Informe a qtde de carros vendidos:\n");
                carrosVendidos = ler.nextInt();

                vlrComissao = comissao * carrosVendidos;
                salarioTotal = salarioFixo + vlrComissao;
                Console.WriteLine("\n\nSalario Fixo   = R$ %8.2f", salarioFixo);
                Console.WriteLine("\nValor Comissao = R$ %8.2f", vlrComissao);
                Console.WriteLine("\n============================");
                Console.WriteLine("\nSalario Total  = R$ %8.2f\n", salarioTotal);
            }

        }
    }
}