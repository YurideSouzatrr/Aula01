using System;

namespace ATV2021
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            Console.WriteLine("      Cadastro de Produtos: ");
            Console.Write("---------------------------------------");
            Console.Write("Quantidade de produtos? ");
            int qtdProdutos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= qtdProdutos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Produto: " + i);
                Console.WriteLine();
                Console.WriteLine("     Caracteristicas ");
                Console.Write("| Comum | Importado | Usado |:");
                string Resposta = Console.ReadLine().ToUpper();

                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Preço: ");
                double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (Resposta == "Comum")
                {
                    lista.Add(new Produto(Nome, Preco));
                }
                else if (Resposta == "Importado ")
                {
                    Console.Write("Anfândega: ");
                    double alfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutosImporta(Nome, Preco, alfandega));
                }
                else
                {
                    Console.Write("Data (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutosUsados(Nome, Preco, data));
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Preço das Etiquetas:");
            foreach (Produto prod in lista)
            {
                Console.WriteLine(prod.Etiqueta());
            }
        }
    }
}
