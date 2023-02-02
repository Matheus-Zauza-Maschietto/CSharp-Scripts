using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4.Entities
{
    public class PessoaFisica: Pessoa
    {
        public double GastoSaude { get; set; }
        public PessoaFisica(string nome, double rendaAnual, double gastoSaude): base(nome, rendaAnual)
        {
            this.GastoSaude = gastoSaude;
        }

        public override double ImpostoDeRenda()
        {
            double imposto = 0;
            if(this.RendaAnual < 20000){
                if(this.GastoSaude > 0)
                    imposto = (this.RendaAnual*0.15)-(this.GastoSaude/2);
                else{
                    imposto = this.RendaAnual*0.15;
                }
                return imposto;
            }
            else{
                if(this.GastoSaude > 0)
                    imposto = (this.RendaAnual*0.25)-(this.GastoSaude/2);
                else{
                    imposto = this.RendaAnual*0.25;
                }
                return imposto;
            }
        }
    }
}