using System;

namespace ATV16
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int cont = 0;

            for (int i = 1; i <= 10)
            {
                Console.Write("Informe a idade da pessoa");
                idade = idade.IntParse("Informe a idade da pessoa");

                if (idade >= 18)
                {
                    cont = cont + 1;
                }
            }

           Console.WriteLine("A quantidade de pessoas com idade maior ou igual a 18 anos é de " + cont);
        }

    }
}
}   
}
