using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4.Entities
{
    public class PessoaJuridica: Pessoa
    {
        public int NumeroFuncionarios { get; set; }
        public PessoaJuridica(int numeroFuncionario, string nome, double rendaAnual): base(nome, rendaAnual)
        {
            this.NumeroFuncionarios = numeroFuncionario;
        }
        public override double ImpostoDeRenda()
        {
            if(this.NumeroFuncionarios <= 10){
                return this.RendaAnual* 0.16;
            }
            return this.RendaAnual* 0.14;
        }
    }
}