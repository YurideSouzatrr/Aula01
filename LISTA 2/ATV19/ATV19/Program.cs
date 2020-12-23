using System;

namespace ATV19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int ant = 0;
            int suc = 0;

            Console.Write("Entre com um numero : ");
            numero = int.Parse(Console.ReadLine());

            // processamento 
            ant = numero - 1;
            suc = numero + 1;

            Console.Write("Antecessor = " + ant + " do núrmero " + numero + " e o sucessor = " + suc);
            Console.ReadKey();

        }
    }
}
