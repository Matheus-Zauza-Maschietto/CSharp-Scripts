using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3.Entities;

public class Circle: Shape
{
    public double Radius { get; set; }
    public Circle(double radius, Color color): base(color)
    {
        this.Radius = radius;
    }
    public override double Area()
    {
        return this.Radius*3.14;
    }
}   
