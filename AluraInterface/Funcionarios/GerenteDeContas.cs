using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraInterface.SistemaInterno;

namespace AluraInterface.Funcionarios
{
    public class GerenteDeContas: FuncionarioAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.25;
        }

        public override double GetBonificacao()
        {
            return Salario*0.05;
        }

        public GerenteDeContas(string cpf): base(cpf, 4000)
        {
            
        }
    }
}