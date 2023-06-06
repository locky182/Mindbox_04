using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Right_Triangle : Triangle, IAreaTriangle
    {
        
        
       


        public double OperationAreaOfTriangle(double a)
        {
            throw new NotImplementedException();
        }

        public double OperationAreaOfTriangle(double a, double b)
        {
            Console.WriteLine($"Aria of RightTriangle: {Figure.CONSTFORRIGHT * a * b}");
            return Figure.CONSTFORRIGHT * a * b;
        }

        public double OperationAreaOfTriangle(double a, double b, double sinOfCorner)
        {
            throw new NotImplementedException();
        }
    }
}
