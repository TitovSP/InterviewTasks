using AreaOfShapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes.Implementations
{
    public class Circle : Shape, IShape
    {
        public uint Radius { get; set; }
        public override double Area => Math.Round(Math.PI * Math.Pow(Radius , 2), 2);
        public Circle()
        {
        }
        public Circle(uint radius)
        {
            Radius = radius;
        }
    }
}
