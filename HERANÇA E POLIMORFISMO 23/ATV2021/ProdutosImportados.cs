using System;
using System.Collections.Generic;
using System.Text;

namespace ATV2021
{
    class ProdutosImportados : Produto
    {
        public double Alfandega { get; set; }

        public ProdutosImportados() 
        {

        }

        public ProdutosImportados(string nome, double preco, double alfandega) : base(nome, preco)
        {
            this.Alfandega = alfandega;
        }


        public override string Etiqueta()
        {
            return Nome + " R$" + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) + "(Alfandega: R$ " + Alfandega.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double PrecoTotal()
        {
            return Preco + Alfandega;
        }
    }
}