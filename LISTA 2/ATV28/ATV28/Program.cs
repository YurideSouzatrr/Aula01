using System;

namespace ATV28
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media = 0;

       
            Console.Write("Entre com a nota 1 : ");
            nota1 = double.Parse(Console.ReadLine());    

            Console.Write("Entre com a nota 2 : ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 3 : ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write(" Entre com a nota 4: ");
            nota4 = double.Parse(Console.ReadLine());


            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.Write("A média ponderada é : " + media);

            Console.ReadKey();   
        }
    }
}
