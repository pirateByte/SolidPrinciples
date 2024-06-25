using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleSolution
{
    internal interface IPaymentService
    {
        void ProcessPayment(double amount);
    }
}
