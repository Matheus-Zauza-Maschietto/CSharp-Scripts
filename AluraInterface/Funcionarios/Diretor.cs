using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraInterface.Funcionarios
{
    public class Diretor: Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }

        public Diretor()
        {
            System.Console.WriteLine("Criando um diretor");
        }
        
    }
}