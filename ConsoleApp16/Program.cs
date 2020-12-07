using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections;
namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //list

            List<string> nomesdelivros = new List<string>();

            Console.Write(" Os Nomes dos Livros são : ");

            nomesdelivros.Add(" | O Nome do Vento  |");
            nomesdelivros.Add("| Agripa |");
            nomesdelivros.Add("| Dom Quixote |");
            nomesdelivros.Add("| 1822 |");
            nomesdelivros.Add("| O Livro da Lua 2021 | ");
            nomesdelivros.Add("| O Povo Brasileiro | ");
            nomesdelivros.Add("| Jesus de Nazaré | ");
            nomesdelivros.Add("| 1889 |");
            nomesdelivros.Add("| O Naufrágio das Civilizações |");
            nomesdelivros.Add("| 21 Lições do Século 21 |");

            foreach (string w in nomesdelivros)
            {
                Console.WriteLine(w);
                
            }
            Console.ReadLine();

        }
        }
    }

