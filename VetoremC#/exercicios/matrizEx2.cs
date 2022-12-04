using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetoremC_.exercicios
{
    public class matrizEx2
    {
        public matrizEx2(){
            Console.Write("Digite um numero M: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];
            ReadMatriz(matriz);  

            ShowMatrizSides(matriz, 0, 2);

        }

        public void ReadMatriz(int[,] mat){
            for(int i=0; i<mat.GetLength(0); i++){
                for(int j=0; j<mat.GetLength(1); j++){
                    Console.Write($"Pos({i}, {j}): ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
        }

        public void ShowMatrizSides(int[,] mat, int posX, int posY){
            if(posX-1 >= 0){
                Console.WriteLine($"Up: {mat[posX-1, posY]}");
            }
            if(posX+1 < mat.GetLength(0)){
                Console.WriteLine($"Down: {mat[posX+1, posY]}");
            }
            if(posY-1 >= 0){
                Console.WriteLine($"Left: {mat[posX, posY-1]}");
            }
            if(posY+1 < mat.GetLength(1)){
                Console.WriteLine($"Right: {mat[posX, posY+1]}");
            }
        }
    }
}