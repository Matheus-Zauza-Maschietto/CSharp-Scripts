using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        SortedSet<int> courseA = new SortedSet<int>();
        SortedSet<int> courseB = new SortedSet<int>();
        SortedSet<int> courseC = new SortedSet<int>();
        int students;
        System.Console.Write("How many students for course A? ");
        students = int.Parse(System.Console.ReadLine());
        for(int index = 0; index < students; index++){
            System.Console.Write($"Students {index}: ");
            courseA.Add(int.Parse(System.Console.ReadLine()));
        }

        System.Console.Write("How many students for course B? ");
        students = int.Parse(System.Console.ReadLine());
        for(int index = 0; index < students; index++){
            System.Console.Write($"Students {index}: ");
            courseB.Add(int.Parse(System.Console.ReadLine()));
        }

        System.Console.Write("How many students for course C? ");
        students = int.Parse(System.Console.ReadLine());
        for(int index = 0; index < students; index++){
            System.Console.Write($"Students {index}: ");
            courseC.Add(int.Parse(System.Console.ReadLine()));
        }

        SortedSet<int> total = new SortedSet<int>();
        total.UnionWith(courseA);
        total.UnionWith(courseB);
        total.UnionWith(courseC);

        System.Console.Write("Total students: ");
        System.Console.WriteLine(total.Count);
    }
}