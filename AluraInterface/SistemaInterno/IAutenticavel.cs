using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraInterface.Funcionarios;

namespace AluraInterface.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha);
    }
}