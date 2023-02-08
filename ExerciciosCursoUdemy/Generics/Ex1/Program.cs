using System;
using System.IO;
using System.Generics;
using Generics.Entities.Ex1;
class Program
{
    public static void Main()
    {
        HashCode<LogRecord> set = new HashSet<LogRecord>();

        System.Console.Write("Enter file full path: ");
        string path = System.Console.ReadLine();

        try{
            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream){
                    string[] line = sr.ReadLine().split(' ');
                    string name = line[0];
    	            DateTime instant = DateTime.Parse(line[1]);
                    set.Add(new LogRecord {Username = name, Instante = instant});
                }
                System.Console.WriteLine("Total user: "+ set.Count);
            }
        }
        catch(IOException e){
            System.Console.WriteLine(e);
        }
    }
}