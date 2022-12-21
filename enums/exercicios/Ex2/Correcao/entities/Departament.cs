using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enums.exercicios.Ex2.Correcao.entities
{
    public class Departament
    {
        public string Name { get; set; }
        public Departament(string name)
        {
            this.Name = name;
        }
    }
}