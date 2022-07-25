using System;
using System.Collections.Generic;
using System.Text;
using FiguresLib.Services;


namespace FiguresLib.Triangles.Implementations
{
    public class Geron: TriangleSquare, IFigureSquare
    {

        public Geron(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;

        }

        public double GetSquare()
        {
            var sides = new List<double>() { SideA, SideB, SideC };
            if (!Validator.TriangleExist(SideA,SideB,SideC))
                return -1;

            double p = Perimeter.GetPerimeter(sides) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
