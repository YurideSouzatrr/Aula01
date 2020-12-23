using System;

namespace ATV27
{
    class Program
    {
        static void Main(string[] args)
        {
			int idade = 0;
			double media = 0, somaDaIdade = 0, cont = 0;

			do
			{
				Console.Write("Digite uma idade ");
				idade = entrada.nextInt();
				if (idade == 0)
				{
					break;
				}
				somaDaIdade += idade;
				cont++;
			} while (idade != 0);

			media = somaDaIdade / cont;
			Console.WriteLine("A média das idades será: " + media);
		}
	}
    }
}
