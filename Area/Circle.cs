using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Circle: Figure, IAreaCircle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double OperationAreaOfCircle(double radius)
        {
            Console.WriteLine($"Area of Circle: {Math.Round(PI * Math.Pow(radius, 2))}");
            return Math.Round(PI * Math.Pow(radius, 2));
        }

       
    }

    
}
