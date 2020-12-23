using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Consultor : Funcionario
    {
        public double ValorHora { get; set; }
        public double HorasTrabalhadas { get; set; }

        public override double CalcularSalario()
        {
            return ValorHora * HorasTrabalhadas;
        }
    }
}
