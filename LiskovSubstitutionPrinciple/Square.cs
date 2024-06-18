﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Square : Rectangle
    {
        public override double Width
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
            
        public override double Height   
        {
            get { return base.Height; }
            set
            {
                base.Width = value;
                base.Height = value;    
            }
        }
    }
}
