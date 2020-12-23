using System;

namespace ATV20
{
    class Program
    {
        static void Main(string[] args)
        {
            int nivel;

            float salario, horas;

            Console.Write("Professor Nível 1 digite 1\n");

            Console.Write("Professor Nível 2 digite 2\n");

            Console.Write("Professor Nível 3 digite 3\n");

            Console.Write("Digite o nivel do professor de acordo com a tabela acima\n");





            Console.Write("%i", nivel);

            Console.Write("Digite a quantia de horas trabalhadas\n");


            if (nivel == 1)
            {

                salario = horas * 12;

                Console.WriteLine("O salario do professor e de %.2f", salario);

            }
            else if (nivel == 2)
            {
                salario = horas * 17;

                Console.WriteLine("O salario do professor e de %.2f", salario);

            }
            else if (nivel == 3)
            {

                salario = horas * 25;

                Console.WriteLine("O salario do professor e de %.2f", salario);

            }
            else
            {

                Console.WriteLine("Nivel de professor inexistente;\n");

            }

            return 0;
        }
        }
    }
   

