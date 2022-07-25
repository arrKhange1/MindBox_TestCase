using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Circles
{
    public class CircleSquare // базовый класс, хранящий все св-ва, которые нужны в разных методах поиска площади у круга
    {
        public double Radius { get; set; }
        public static double PI { get { return Math.PI; } }

    }
}

