using System;

namespace ATV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;
            const int ANO = 365;
            int resultado = 0;

            Console.Write("Digite seu nome : ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade : ");
            idade = int.Parse(Console.ReadLine());

            
            resultado = idade * ANO;

            Console.Write(nome + " , Você ja viveu " + resultado + " dias");

            Console.ReadKey();  

        }
    }
}
