using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraInterface.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }

        public Auxiliar(string cpf): base(cpf, 2000)
        {
            
        }
    }
}