

using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Dictionary<string, int> candidatos = new Dictionary<string, int>();

        System.Console.Write("Enter fule full path: ");
        string path = System.Console.ReadLine();

        try{
            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream){
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    int votes = int.Parse(line[1]);

                    if(candidatos.ContainsKey(name)){
                        candidatos[name] += votes;
                    }
                    else{
                        candidatos.Add(name, votes);
                    }
                }
            }

            foreach(var item in candidatos){
                System.Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }   
        catch(IOException e){
            System.Console.WriteLine($"erro: {e}");
        }
    }
}