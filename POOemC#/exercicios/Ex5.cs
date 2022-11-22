using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano 
// (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no 
// ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam 
// para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver 
// este problema.

namespace POOemC_.exercicios
{   
    public class Aluno{
        private string Nome { get; set; }
        private double Nota1 { get; set; }
        private double Nota2 { get; set; }
        private double Nota3 { get; set; }

        public Aluno(double nota1, double nota2, double nota3, string nome){
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            nota3 = nota3;
        }

        public double NotalFinal(){
            return Nota1+Nota2+Nota3;
        }

        public bool Aprovado(){
            if(NotalFinal() >= 6.0){
                return true;
            }
            else{
                return false;
            }
        }
    }

    public class Ex5
    {
        
    }
}