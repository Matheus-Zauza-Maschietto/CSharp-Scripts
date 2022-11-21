// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002

namespace exercicios.ex3
{
    public class ex3
    {
        string senha = "2002";
        string tentativa = "";
       public ex3(){
            while(senha!=tentativa){
                Console.Write("Digite a senha: ");
                tentativa = Console.ReadLine();
                if(senha!=tentativa){
                    Console.WriteLine("Senha incorreta, tente novamente.");            
                } 
            }
            Console.WriteLine("Acesso permitido");
       } 
    }
}