using System;

namespace ATV21
{
    class Program
    {
        static void Main(string[] args)
        {
       int a = real;

            int idade;

          Console.Write("Informe a sua idade");
            idade = Integer.parseInt(JOptionPane.showInputDialog("Informe a sua idade"));

            if (idade <= 4)
            {
               Console.WriteLine("Muito jovem!");
            }

            if ((idade >= 5) && (idade <= 7))
            {
                Console.WriteLine("Infantil A");
            }

            if ((idade >= 8) && (idade <= 10))
            {
                Console.WriteLine("Infantil B");
            }

            if ((idade >= 11) && (idade <= 13))
            {
                Console.WriteLine("Juvenil A");
            }

            if ((idade >= 14) && (idade <= 17))
            {
                Console.WriteLine("Juvenil B");
            }

            if (idade >= 18)
            {
               Console.WriteLine("Adulto");
            }

        }
    }
}
  
