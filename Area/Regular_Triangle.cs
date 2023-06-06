using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Regular_Triangle : Triangle, IAreaTriangle
    {
        double A { get; set; }
        public double B { get; set; }
        public double SinOfCornerAandB;  

        public Regular_Triangle(double a, double b, double sinOfCornerAandB)
        {
            A = a;      
            B = b;
            SinOfCornerAandB = sinOfCornerAandB;

        }
        public double OperationAreaOfTriangle(double a)
        {
            throw new NotImplementedException();
        }

        public double OperationAreaOfTriangle(double a, double b, double sinOfCorner)
        {
            Console.WriteLine($"Area of Regular_Triangle:" +
                $"{Math.Round(0.5 * a * b * Math.Sin(sinOfCorner))}");

            return Math.Round(0.5 * a * b * Math.Sin(sinOfCorner));

        }

        public double OperationAreaOfTriangle(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
}
