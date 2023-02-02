using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3.Entities;

abstract class Shape
{
    public Color Color { get; set; }

    public Shape(Color color)
    {
        this.Color = color;
    }
    public abstract double Area();
}
