using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Teste
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.Comissao = 10;
            vendedor.NumeroVendas = 10;

            double salarioVendedor = vendedor.CalcularSalario();
            Console.WriteLine(salarioVendedor);

            Consultor consultor = new Consultor();
            consultor.ValorHora = 20;
            consultor.HorasTrabalhadas = 100;

            double salarioConsultor = consultor.CalcularSalario();
            Console.WriteLine(salarioConsultor);

            Gerente gerente = new Gerente();
            gerente.Bonificacao = 500;

            double salarioGerente = gerente.CalcularSalario();
            Console.WriteLine(salarioGerente);

            Console.ReadKey();
        }
    }
}
