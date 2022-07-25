using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresLib.Services
{
    public class Validator
    {
        public static bool TriangleExist(double a, double b, double c)
        {
            bool exist = a + b > c && b + c > a && a + c > b;
            if (!exist)
                Console.WriteLine("\nThe triangle doesn't exist\n");
            return exist;
        }

        public static bool TriangleRectangular(double a, double b, double c)
        {
            bool rect = a*a + b*b == c*c || b*b + c*c == a*a || a*a + c*c == b*b;
            if (rect)
                Console.WriteLine("You are lucky, the triangle is rectangular!\n");
            else
                Console.WriteLine("Bad luck, the triangle is not rectangular :(\n");
            return rect;
        }

        public static bool TriangleRightValues(out double a, out double b, out double c)
        {
            a = 0; b = 0; c = 0;
            try
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());

                if (a <= 0 || b <= 0 || c <= 0)
                    throw new FormatException();
                return true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Some values are incorrect");
                return false;
            }
        }

        public static bool RightValue(out double val)
        {
            val = 0;
            if (!double.TryParse(Console.ReadLine(), out val) || val <= 0)
            {
                Console.WriteLine("Irright value");
                return false;
            }
            return true;
                
        }

        
    }
}
