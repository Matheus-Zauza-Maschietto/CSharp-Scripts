using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraInterface.Funcionarios

{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }

        public abstract double GetBonificacao();

        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            TotalFuncionarios++;
            System.Console.WriteLine("Criando um Funcionario");
        }

        public abstract void AumentarSalario();

    }


}