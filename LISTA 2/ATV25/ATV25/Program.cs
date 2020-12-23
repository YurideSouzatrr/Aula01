using System;

namespace ATV25
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntpessoas = 5;

            int idades[qntpessoas];   //cria a var. para as idades

           int pesos [qntpessoas];    //var. para pesos

           int alturas[qntpessoas];  //var. para alturas

            float media_altura = 0;

            int idade50 = 0;   //var. para quantidade de pessoas com mais de 50

            int idade1020 = 0; //var. para quantidade de pessoas entre 10 a 20 anos

            int pesos_total = 0;

            for (int cont = 0; cont < qnt_pessoas; cont++)
            {  //loop(repeticao) 5 vezes

               Console.Write("Digite a idade: ");

               Console.WriteLine("%i", &idades[cont]);  //recebe as 5 pessoas na variável pessoas

            Console.Write("Digite o peso: ");

               Console.WriteLine("%i", &pesos[cont]);  //recebe as 5 pessoas na variável pesos

                Console.Write("Digite a idade: ");

                Console.Write("%i", &alturas[cont]);  //recebe as 5 alturas na variável alturas

                Console.WriteLine("\n");

                if (idades[cont] > 50)

                    idade50++;

                if (idades[cont] >= 10 && idades[cont] <= 20)
                {

                    idade1020++;

                    media_altura += alturas[cont];

                }

                pesos_total += pesos[cont];

            }

            Console.WriteLine("Pessoas com mais de 50 anos: %i\n", idade50);
Console.WriteLine("Média de altura de pessoas entre 10 a 20 anos: %i\n", media_altura / idade1020);

        Console.WriteLine("Média de pesos: %i\n", pesos_total / qnt_pessoas);

        }
    }
    }
}
