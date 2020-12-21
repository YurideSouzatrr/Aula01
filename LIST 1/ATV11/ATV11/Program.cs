using System;

namespace ATV11
{
	class Program
	{
		static void Main(string[] args)
		{
            Scanner entrada = new Scanner();

            int num[] = new int[10];
			int qtdNegativos = 0;
	       int positivos = 0; 

			for (int cont = 0; cont < 10; cont++)
			{
				Console.WriteLine("Insira o " + (cont + 1) + "° número Real: ");

                object v = entrada.nextFloat();
                num[cont] = v;

                if (!(num[cont] > = 0))
                {
                    ++qtdNegativos;
                }
                else
                {
                    positivos = positivos + num[cont];
                }
            }

			if (qtdNegativos > 0)
			{
				Console.WriteLine("A quantidade de números Reais negativos é: "
						+ qtdNegativos);
			}

			if (positivos > 0)
			{
				Console.WriteLine("A soma dos números positivos do vetor é: "
						+ positivos);
			}
		}
	}
}