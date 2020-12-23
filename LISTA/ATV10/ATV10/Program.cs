using System;

namespace ATV10
{
    class Program
    {
        static void Main(string[] args)
        {
            double abastecimento = 0;
            const double LITRO = 3.74d;
            double qtd_litros = 0;

           
            Console.Write("Qual o valor que deseja abastacer : ");
            abastecimento = double.Parse(Console.ReadLine());   

            qtd_litros = abastecimento / LITRO; 

            
            Console.Write("Litros abastecido com o valor de RS" + abastecimento + " foi de : " + qtd_litros);

            Console.ReadKey();
        }
    }
}
