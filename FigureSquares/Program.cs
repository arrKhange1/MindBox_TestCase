using System;
using FiguresLib;
using FiguresLib.Circles.Implementations;
using FiguresLib.Triangles.Implementations;
using FiguresLib.Services;
using System.Collections.Generic;

namespace FigureSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle\nEnter 3 sides:\n");


            if (!Validator.TriangleRightValues(out double a, out double b, out double c))
                return;

            double triangleSquare = new Geron(a, b, c).GetSquare();
            if (triangleSquare != -1)
            {
                Console.WriteLine($"\nTriangle square: {triangleSquare}\n");
                Validator.TriangleRectangular(a, b, c);
            }


            Console.WriteLine("Circle\nEnter R:\n");

            if (!Validator.RightValue(out double R))
                return;

            Console.WriteLine($"Circle square: {new Radius(R).GetSquare()}");


        }
    }
}
