using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresLib.Services
{
    public class Perimeter
    {
        public static double GetPerimeter(List<double> sides)
        {
            if (sides.Count == 0)
                return -1;
            return sides.Aggregate((currSide, nextSide) => currSide + nextSide);
        }
    }
}
