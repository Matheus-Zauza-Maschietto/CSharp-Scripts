using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4.Entities;

public abstract class Pessoa
{
    public string Nome { get; set; }
    public double RendaAnual { get; set; }
    
    public Pessoa(string nome, double rendaAnual)
    {
        this.Nome = nome;
        this.RendaAnual = rendaAnual;
    }

    public abstract double ImpostoDeRenda();
}
