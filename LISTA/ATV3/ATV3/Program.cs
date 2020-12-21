using System;

namespace ATV3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double aumento = 0;
            double novoSalario;


            Console.Write("Digite o valor do salario : ");
            salario = double.Parse(Console.ReadLine());


            Console.Write("Digite o valor do aumento em porcentagem : ");
            aumento = double.Parse(Console.ReadLine());

            aumento = salario * (aumento / 100);
            novoSalario = aumento + salario;


            Console.Write("O valor do aumento é : R$" + aumento + "\n");

            Console.Write("O valor do novo salário : R$" + novoSalario + "\n");


            Console.ReadKey();
        }
    }
}
