using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
// cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
// menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma)

namespace exercicios.ex4
{
    public class ex4
    {
        int cordenadaX = 0;
        int cordenadaY = 0;
        public ex4(){
            do{
                Console.Write("Digite a cordenadaX: ");
                cordenadaX = int.Parse(Console.ReadLine());
                Console.Write("Digite a cordenadaY: ");
                cordenadaY = int.Parse(Console.ReadLine());

                if(cordenadaX > 0 && cordenadaY > 0){
                    Console.WriteLine("Quadrante 1");
                }
                else if(cordenadaX > 0 && cordenadaY < 0){
                    Console.WriteLine("Quadrante 2");
                }
                else if(cordenadaX < 0 && cordenadaY > 0){
                    Console.WriteLine("Quadrante 3");
                }
                else if(cordenadaX < 0 && cordenadaY < 0){
                    Console.WriteLine("Quadrante 4");
                } 
            }while(cordenadaX!=0 && cordenadaY!=0);
        }
    }
}