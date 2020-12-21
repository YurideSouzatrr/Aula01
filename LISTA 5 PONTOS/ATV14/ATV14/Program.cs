using System;

namespace ATV14
{
    class Program
    {
        static void Main(string[] args)
        {

            int Numero;

            Console.Write("\nDigite um numero:");

            Console.WriteLine("%d", &Numero);

            if (Numero > 200  Numero < 100){ 
                Console.WriteLine("%d esta entre 200 e 100\n", Numero);
            }
    else
            {
                Console.WriteLine("%d nao nao esta entre 100 e 200\n", Numero);
            }


            return 0;
        }
    }
}
}