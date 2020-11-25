using System;

namespace ConsoleApp5
{
    class Reserva
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        static void Main(string[] args)
        {
			Console.Write("Olá Quantos quartos serão alugados ?");
			int qtdReservar = int.Parse(Console.ReadLine());
			Console.WriteLine("");

			Reserva[] vect = new Reserva[10];
			int reserva = 1;

			for (int i = 0; i < qtdReservar; i++)
			{
				Console.WriteLine("Reserva #" + reserva++ + ":");
				Console.Write("Nome:");
				string nome = Console.ReadLine();
				Console.Write("Email:");
				string email = Console.ReadLine();
				Console.Write("Quarto:");
				int quarto = int.Parse(Console.ReadLine());
				Console.WriteLine("");

				vect[quarto] = new Reserva { Nome = nome, Email = email };
			}

			Console.WriteLine("Quartos ocupados:");
			for (int i = 0; i < 10; i++)
			{
				if (vect[i] != null)
				{
					Console.WriteLine(i + ":  " + vect[i].Nome + ", " + vect[i].Email);
				}
			}

		}
	}

}
    