using System.Globalization;
using System;
using System.Collections.Generic;
using Ex3.Entities;
class Program{
    public static void Main(){
        List<Shape> list = new List<Shape>();
        System.Console.Write("Enter the numver of shapes: ");
        int shapes = int.Parse(System.Console.ReadLine());

        for(int index = 0; index<shapes; index++)
        {
            System.Console.WriteLine($"Shape #{index} data: ");
            System.Console.Write("Rectangle or Clircle (r/c): ");
            char ch = char.Parse(System.Console.ReadLine());
            System.Console.Write("Color (black/blue/red): ");
            Color color = Enum.Parse<Color>(System.Console.ReadLine());

            if(ch == 'r')
            {
                System.Console.Write("Width: ");
                double width = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Height: ");
                double height = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Rectangle(width, height, color));
            }
            else{
                System.Console.Write("Radius: ");
                double radius = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Circle(radius, color));
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Shape Areas: ");
        foreach(Shape item in list)
        {
            System.Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
