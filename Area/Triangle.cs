using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public abstract class Triangle: Figure
    {
       
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double SinOfCornerAandB { get; set; }
    }
}
