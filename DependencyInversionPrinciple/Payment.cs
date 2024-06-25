using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class Payment
    {
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}
