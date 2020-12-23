using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO_T1
{
    class Veterinario
    {

        class acessoBD
            MySqlConnnection con;


        public acessoBD()
        {

            try


                string banco "server=localhost;user id=root"" = True;database=teste"; "
                   con = new MySqlConnnection(patch)
                   }
        }

        catch(Exception e)
    }

    Console.WriteLine(" Bem vindo )

}        
 }       
        
        
        
        
        public Int64 cpf;
        public string nome;
        public DateTime data;
        public int registro;

        public void imprimir()
        {
            Console.Write("\n\ncpf: " + cpf);
            Console.Write("\nnome: " + nome);
            Console.Write("\nregistro: " + registro);
            Console.Write("\ndata de nascimento: " + data);
        }
    }
}
