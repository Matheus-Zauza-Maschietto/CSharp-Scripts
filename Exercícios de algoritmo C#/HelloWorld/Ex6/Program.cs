// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var fibo = new fibonatie();

int i=0;
int n=5;
string ans="";
int[] linha = fibo.fibonacci(n, previousList: new int[0]);
Console.WriteLine(linha.Length);
while(i<n)
{
    ans =ans + linha[i].ToString() +" ";
    i++;
}
Console.WriteLine(ans);
