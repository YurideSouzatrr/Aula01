using System;

namespace ATV26
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int sexo = 0;

            int totalPessoasMasculino = 0;
            int totalPessoasFeminino = 0;


            while ((idade != -1 || idade != 0))
            {

                Console.Write("Digite a idade:  ");
                idade = Convert.ToInt32(Console.ReadLine());

                //Finaliza se a idade for -1 ou 0
                if (idade == -1 || idade == 0)
                {
                    break;
                }

                Console.Write("Digite o sexo [0] Masculino [1] Feminino:  ");
                sexo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (sexo == 0)
                    totalPessoasMasculino = totalPessoasMasculino + 1;

                if (sexo == 1 && (idade > 29 && idade < 46))
                    totalPessoasFeminino = totalPessoasFeminino + 1;

            }

            Console.WriteLine("");
            Console.WriteLine(".....");
            Console.WriteLine("Masculinos = " + totalPessoasMasculino);
            Console.WriteLine("Femininos entre 30 e 45 anos = " + totalPessoasFeminino);
        }
    }
}
