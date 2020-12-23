using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHoras { get; set; }

        public Funcionarios()
        {

        }

        public Funcionarios(string nome, int horas, double valorporhoras)
        {
            this.Nome = nome;
            this.Horas = horas;
            this.ValorPorHoras = valorporhoras;
        }

        public virtual double FormadePagamento()
        {
            return Horas * ValorPorHoras;
        }
    }
}
