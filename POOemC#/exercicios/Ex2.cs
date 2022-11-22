
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

// Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário 
// médio dos funcionários

namespace POOemC_.exercicios.introducao
{
    public class Funcionarios
    {
        public string Nome { get; set; }
        public float Salario { get; set; }
        public Funcionarios(){
            Console.Write("Digite o nome: ");
            Nome = Console.ReadLine();
            Console.Write("Digite o salario: ");
            Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }

    public class Ex2{
        public Ex2(){
            Funcionarios fun1 = new Funcionarios();
            Funcionarios fun2 = new Funcionarios();
            double media = (fun1.Salario+fun2.Salario)/2.0;
            Console.WriteLine($"A média de salarios é de: {media}");
        }
    }
}