using System;
using System.Collections.Generic;
using System.Text;

namespace ATV2021
{
    class ProdutosUsados : Produto
    {
        public DateTime Fabricacao { get; set; }

        public ProdutosUsados()
        {

        }

        public ProdutosUsados(string nome, double preco, DateTime fabricacao)
        : base(nome, preco)
        {
            this.Fabricacao = fabricacao;
        }

        public override string Etiqueta()
        {
            return Nome + " usado - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " Data de Fabricação: " + Fabricacao.ToString("dd/mm/yyyy") + ")";
        }
    }
}
