using AreaOfShapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes.Implementations
{
    public class Shape : IShape
    {
        private IShape figure;
        public virtual double Area => figure == null ? default : figure.Area;
        protected Shape()
        {
        }
        public Shape(IShape figure)
        {
            this.figure = figure;
        }
    }
}
