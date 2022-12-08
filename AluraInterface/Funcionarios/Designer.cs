using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraInterface.Funcionarios
{
    public class Designer: Funcionario
    {
        public override void AumentarSalario(){
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario*0.17;
        }
        public Designer(string cpf): base(cpf, 3000)
        {
            
        }
    }
}