using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraInterface.SistemaInterno;

namespace AluraInterface.Parceria
{
    public class ParceiroComercial: IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }

}