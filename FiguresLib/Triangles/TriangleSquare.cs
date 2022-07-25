using System;
using System.Collections.Generic;
using System.Text;
using FiguresLib.Services;

namespace FiguresLib.Triangles
{
    public class TriangleSquare // базовый класс, хранящий все св-ва, которые нужны в разных методах поиска площади у треугольника
    {
        protected double SideA { get; set; }
        protected double SideB { get; set; }
        protected double SideC { get; set; }
        protected double Height { get; set; }
        protected double Angle { get; set; }
        

    }
}


