using System;

namespace ATV18
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlr_custo = 0;  
            String marca = ""; 
            String modelo = "";
            double vlr_final = 0;
            double vlr_comissao = 0;
            double vlr_imposto = 0;


            Console.Write("Entre com a marca do veículo : ");  
            marca = Console.ReadLine(); 
            Console.Write("Entre com o modelo do veículo : "); 
            modelo = Console.ReadLine(); 

            Console.Write("Entre com o valor do custo do veículo : "); 
            vlr_custo = double.Parse(Console.ReadLine());

            vlr_imposto = (vlr_custo * 0.45); 
            vlr_comissao = (vlr_custo * 0.28); 

            vlr_final = vlr_custo + vlr_imposto + vlr_comissao;

            Console.Write("-------------------------------     \n");  
            Console.Write("Resultado Final\n");
            Console.Write("-------------------------------     \n");
            Console.Write("Marca do veículo : " + marca + "\n");
            Console.Write("-------------------------------     \n");
            Console.Write("Modelo do veículo : " + modelo + "\n");
            Console.Write("-------------------------------     \n");
            Console.Write("Valor do veículo : " + vlr_final + "\n");
            Console.Write("-------------------------------");

            Console.ReadKey(); 

        }
    }
}
    
