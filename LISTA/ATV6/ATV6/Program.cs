using System;

namespace ATV6
{
    class Program
    {
        static void Main(string[] args)
        {
            double juros = 0.7;
            double deposito = 0;
            double rendimento = 0;
            double total = 0;

            Console.Write("Digite o valor depositado : ");
            deposito = double.Parse(Console.ReadLine());

            
            rendimento = juros * deposito;

            total = deposito + rendimento;

            Console.Write("O rendimento do depósito após um més é de um total de : " + total);

            Console.ReadKey();
        }
    }
}
