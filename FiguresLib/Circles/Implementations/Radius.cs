using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Circles.Implementations
{
    public class Radius : CircleSquare, IFigureSquare
    {
        public Radius(double r)
        {
            Radius = r;
        }
        public double GetSquare()
        {
            return PI * Radius * Radius;
        }
    }
}
