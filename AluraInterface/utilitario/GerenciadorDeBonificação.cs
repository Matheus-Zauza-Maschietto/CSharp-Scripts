using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraInterface.Funcionarios;

namespace AluraInterface.utilitario
{
    public class GerenciadorDeBonificação
    {
        public double TotalDeBonificações { get; private set; }

        public void Registrar(Funcionario fun)
        {
            this.TotalDeBonificações += fun.GetBonificacao();
        }

    }
}