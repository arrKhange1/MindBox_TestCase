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
            var sides = new List<double>() {SideA, SideB, SideC };
            double perimeter = Perimeter.GetPerimeter(sides);
            double halfPerimeter = perimeter / 2;

            if (!Validator.TriangleExist(SideA,SideB,SideC) || perimeter == -1)
                return -1;

            
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }
    }
}
