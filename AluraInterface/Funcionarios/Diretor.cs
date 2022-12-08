using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraInterface.SistemaInterno;

namespace AluraInterface.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {
        public override double GetBonificacao()
        {
            return this.Salario*0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public Diretor(string cpf): base(cpf, 5000)
        {

        }
        
    }
}