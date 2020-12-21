using System;

namespace ATV2
{
    class Program
    {
        private static object ler;

        static void Main(string[] args)
        {
            int eleitores, brancos, nulos, validos; 
            string ler;
            double percBrancos, percNulos, percValidos;

            Console.Write("Informe o nro de eleitores:\n");
            eleitores = ler.nextInt();
            Console.Write("\nInforme o nro de votos validos:\n");
            validos = ler.nextInt();
            Console.Write("\nInforme o nro de votos em branco:\n");
            brancos = ler.nextInt();
            Console.Write("\nInforme o nro de votos nulos:\n");
            nulos = ler.nextInt();

            percValidos = ((double)validos / eleitores) * 100;
            percBrancos = ((double)brancos / eleitores) * 100;
            percNulos = ((double)nulos / eleitores) * 100;

            Console.WriteLine("\n\n%6.2f%% de votos validos.", percValidos);
            Console.WriteLine("\n%6.2f%% de votos em branco.", percBrancos);
            Console.WriteLine("\n%6.2f%% de votos nulos.\n", percNulos);
        }
    }
}
