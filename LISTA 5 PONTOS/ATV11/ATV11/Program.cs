using System;

namespace ATV11
{
    class Program
    {
        static void Main(string[] args)
        {
            const double KG = 12d;
            double peso = 0;
            double pagar = 0;


            Console.Write("Entre com o peso : ");
            peso = double.Parse(Console.ReadLine());

            pagar = peso * KG;

            Console.Write("Valor a pagar : " + pagar);

            Console.ReadKey();
        }
    }
}
