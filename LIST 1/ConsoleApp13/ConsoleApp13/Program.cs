using System;

namespace ConsoleApp13
{
    class Program
    {
        static int Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Digite o numero 1");
            numero = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            for (int x = 1; x <= 10; +x++)
            {
                resultado = numero * x;
                Console.WriteLine(resultado);

            }
        }
    }
    }