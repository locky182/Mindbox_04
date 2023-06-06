using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public interface IAreaTriangle
    {
        double OperationAreaOfTriangle(double a);
        double OperationAreaOfTriangle(double a, double b, double sinOfCorner );
        double OperationAreaOfTriangle(double a, double b);


    }
}
