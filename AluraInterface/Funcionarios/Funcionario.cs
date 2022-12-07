using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraInterface.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        public static int TotalFuncionarios { get; private set; }

        public virtual double GetBonificacao(){
            return Salario*0.1;
        }

        public Funcionario()
        {
            TotalFuncionarios++;
            System.Console.WriteLine("Criando um Funcionario");
        }
    }


}