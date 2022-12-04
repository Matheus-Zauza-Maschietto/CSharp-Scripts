using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetoremC_.exercicios
{
    public class matrizEx1
    {
        public matrizEx1(){
            System.Console.WriteLine("Digite o tamanho de uma matriz N: ");
            int matSize = int.Parse(Console.ReadLine());
            int[,] matriz = new int[matSize, matSize];
            ReadMatriz(matriz);
            WriteMatriz(matriz);
        }

    public void WriteMatriz(int[,] mat){
        for(int i=0; i<mat.GetLength(0); i++){
            for(int j=0; j<mat.GetLength(1); j++){
                Console.Write(mat[i, j]+" ");
            }
            Console.WriteLine();
        }
    }
    public void ReadMatriz(int[,] mat){
        for(int i=0; i<mat.GetLength(0); i++){
            for(int j=0; j<mat.GetLength(1); j++){
                Console.Write($"Posição ({i}{j}): ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    }
}