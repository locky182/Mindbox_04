using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Program
    {
        private static double sinOfRightCornerAandB = Math.Sin(45);

        static void Main(string[] args)
        {
            Circle circle1 = new Circle(23.4);
           circle1.OperationAreaOfCircle(circle1.Radius);

            Regular_Triangle regular_Triangle = new Regular_Triangle(12.4, 34.6, 34.0);
            regular_Triangle.OperationAreaOfTriangle(12.4, 34.6, 34.0);

            Right_Triangle right_Triangle = new Right_Triangle();
            right_Triangle.OperationAreaOfTriangle(12.6, 34.6);

            Console.ReadLine();
        }
    }
}
