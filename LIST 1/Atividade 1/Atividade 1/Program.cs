using System;
using System.Diagnostics;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = " Caio  " ;
            string idade = " 20 ";
            string salario = " 3200 ";
            string datadenascimento = " 16/12/1995 ";
            string filmepreferido = " 12 Anos de Escravidão";

            NewMethod(nome, idade, salario, filmepreferido);
            Console.ReadKey();
        }

        private static void NewMethod(string nome, string idade, string salario, string filmepreferido)
        {
            throw new NotImplementedException();
        }

        private static void NewMethod(string nome, string idade, string salario, string datadenascimento, string filmepreferido)
        {
            Console.WriteLine(nome  + idade + salario + datadenascimento + filmepreferido);
        }
    }
    }

