using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicios.ex1
{
    public class ex1
    {
       public string Produto1 { get; set; } = "Computador";
       public string Produto2 { get; set; } =  "Mesa de escritorio";
       public byte Idade { get; set; } = 30;
       public int Codigo { get; set; } = 5290; 
       public char Genero { get; set; } = 'M';
       public double Preco1 { get; set; } = 2100.0; 
       public double Preco2 { get; set; } =  650.50;
       public double Medida { get; set; } =  53.423543;

        public ex1(){
            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{Produto1}, cujo preço é $ {Preco1}");
            Console.WriteLine($"{Produto2}, cujo preço é $ {Preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {Idade} anos de idade, código {Codigo} e gênero: {Genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {Medida}");
            Console.WriteLine($"Arredondado (três casas decimais): {Medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {Medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }

    }
}