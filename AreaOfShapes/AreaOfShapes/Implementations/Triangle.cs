using AreaOfShapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes.Implementations
{
    public class Triangle : Shape, IShape
    {
        public uint SideA { get; set; }
        public uint SideB { get; set; }
        public uint SideC { get; set; }
        public override double Area
        {
            get
            {
                double p = (SideA + SideB + SideC) / 2.0;
                return Math.Round( Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)), 2);
            }
        }
        public Triangle()
        {
        }
        public Triangle(uint sideA, uint sideB, uint sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public bool IsRightTriangle()
        {
            return (SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                || SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)));
        }
    }
}
