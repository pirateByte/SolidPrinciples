using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleSolution
{
    internal class Square : IShape
    {
        public double SideLength { get; set; }

        public double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
