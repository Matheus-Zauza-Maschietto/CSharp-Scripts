using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraInterface.SistemaInterno;

namespace AluraInterface.Funcionarios
{
    public abstract class FuncionarioAutenticavel: Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
        public FuncionarioAutenticavel(string cpf, double salario): base(cpf, salario)
        {
            
        }
    }
}