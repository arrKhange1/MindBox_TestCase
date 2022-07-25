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
            return sides.Aggregate((currSide, nextSide) => currSide + nextSide);
        }
    }
}
