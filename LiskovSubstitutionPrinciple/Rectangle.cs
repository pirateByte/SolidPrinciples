using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Rectangle
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
