using System;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> lista = new List<Funcionarios>();

    
            Console.WriteLine("  Empresa 1 ");
            Console.WriteLine("Quantidade de funcionarios: ");
            int numeroFunci = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= numeroFunci; i++)
            {
                Console.WriteLine("Funcionário: " + i);
                Console.Write("Terceirizado: [S/N] ? ");
                string SimNao = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por Horas: ");
                double valorporhoras = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (SimNao == "S")
                {
                    Console.WriteLine("Cobrança Adicional: ");
                    double cobrancaadicional = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new FuncionarioTerceirizado(nome, horas, valorporhoras, cobrancaadicional));
                }
                else
                {
                    lista.Add(new Funcionarios(nome, horas, valorporhoras));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS: ");
            foreach (Funcionarios func in lista)
            {
                Console.WriteLine(func.Nome + " - " + func.FormadePagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
