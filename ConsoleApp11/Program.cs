using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] v = new int[6];
                int i; //contado do for.

                for (i = 0; i < 6; i++)
                {
                    Console.Write("Digite os números : ");
                    v[i] = Convert.ToInt16(Console.ReadLine());
                    
                }

                Console.WriteLine(" Os números são : ");
                for (i = 0; i < 6; i++)
                {
                    if (v[i] % 2 == 0) 
                    {
                        Console.WriteLine(v[i] + ":");
                    }
                    else
                    {
                        Console.WriteLine(v[i] + ":");
                    }
                }
            }
                }
            }
        }
