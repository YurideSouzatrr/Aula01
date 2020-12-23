using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Gerente : Funcionario
    {
        public double Bonificacao { get; set; }

        public override double CalcularSalario()
        {
            return (6 * base.CalcularSalario()) + Bonificacao;
        }
    }
}
