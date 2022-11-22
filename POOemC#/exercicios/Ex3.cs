using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Fazer um programa para ler os valores da largura e altura de um retângulo. Em 
// seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe 
// como mostrado no projeto ao lado

namespace POOemC_.exercicios.introducao
{   
    public class retangulo{
        private double Largura;
        private double Altura;

        public retangulo(double largura, double altura){
            Largura = largura;
            Altura = altura;
        }

        public double Area(){
            return Largura*Altura;
        }

        public double Perimetro(){
            return (Largura*2)+(Altura*2);
        }

        public double Diagonal(){
            return (Math.Sqrt((Largura*Largura)+(Altura*Altura)));
        }

    }

    public class Ex3
    {
        
    }
}