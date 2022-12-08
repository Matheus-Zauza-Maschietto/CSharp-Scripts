using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraInterface.Funcionarios;

namespace AluraInterface.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool UsuarioAutenticado = funcionario.Autenticar(senha);
            if(UsuarioAutenticado)
            {
                System.Console.WriteLine("Boas vindas ao nosso sistema");
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    
    }
}