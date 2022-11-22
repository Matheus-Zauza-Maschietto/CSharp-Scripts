using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Fazer um programa para ler os dados de um funcionário (nome, 
// salário bruto e imposto). Em seguida, mostrar os dados do 
// funcionário (nome e salário líquido). Em seguida, aumentar o salário 
// do funcionário com base em uma porcentagem dada (somente o 
// salário bruto é afetado pela porcentagem) e mostrar novamente os 
// dados do funcionário. Use a classe projetada abaixo.

namespace POOemC_.exercicios.introducao
{
    public class Funcionario{
        private string Nome { get; set; }
        private double SalarioBruto { get; set; }
        private double Imposto { get; set; }    

        public Funcionario(string nome, double salarioBruto, double Imposto){
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = Imposto;
        }

        public double SalarioLiquido(){
            return SalarioBruto-Imposto;
        }
        public void AumentarSalario(double Porcentagem){
            SalarioBruto +=(SalarioBruto*(Porcentagem/100));
        }
        public override string ToString()
        {
            return $"Salario Bruto: {SalarioBruto} - Salario Liquido: {SalarioLiquido()}";
        }
    }

    public class Ex4
    {
        
    }
}