using System;

namespace ATV23
{
    class Program
    {
        static void Main(string[] args)
        {
            float compras;
            char nome;
            int i;

            for (i = 0; i < 15; i++)
            {
                Console.Write("entre com o nome");
                Console.WriteLine("% c", nome);
            }
            for (i = 0; i < 15; i++)
            {
               Console.Write("entre com o valos das suas compras");
                Console.WriteLine("% f", compras);
            }
            for (i = 0; i < 15; i++)
            {
                if (compras <= 1000)
                {
                    bonus = (compras) * 10 / 100;
                    Console.WriteLine("bônus= % f", bônus);
                }
                if (compras > 1000)
                {
                    bônus = (compras) * 15 / 100;
                   Console.Writeline("bônus=% f", bônus);
                }
            }
    }
}