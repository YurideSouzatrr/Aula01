using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Vendedor : Funcionario
    {
        public double Comissao { get; set; }
        public long NumeroVendas { get; set; }

        public override double CalcularSalario()
        {
            return base.CalcularSalario() + (Comissao * NumeroVendas);
        }
    }
}
