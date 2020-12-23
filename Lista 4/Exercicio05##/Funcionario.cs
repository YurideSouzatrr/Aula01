using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public long Cpf { get; set; }

        public virtual double CalcularSalario()
        {
            return 954;
        }

        public bool Contratar()
        {
            return true;
        }

        public bool Demitir()
        {
            return false;
        }
    }
}
