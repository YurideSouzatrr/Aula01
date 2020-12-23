using System;

namespace LIST42020
{
    class Program
    {
        static void Main(string[] args);
             public class Gerente : Funcionario
        {
            string departamento;
            double salario;
            int matricula;
        }

        public class Assistente : Funcionario
        {
            private int matricula;
            private string nome;
            private string cpf;
            private string salario;

            public void getMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public void exibeDados()
        {
                Console.WriteLine("Nome: " + nome +" Cpf: " + cpf + " Salario: " + salario + " Matricula: " + matricula);
        }
    }


    public class Administrativo : Assistente
    {
        String turno;
            private double salario;

            public void adicionalNoturno(double adicional)
    {
        if (turno == "noturno" || turno == "Noturno")
        {
                    this.salario = salario + adicional;
        }
    }
}

public class Tecnico : Assistente
{
            private int salario;

            public double bonusSalarial()
{
    this.salario = (int)(this.salario + (this.salario * 0.1));
    return this.salario;
}

}
        }
    }