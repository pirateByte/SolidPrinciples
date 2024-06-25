using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class UPIPaymentService
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing UPI payment of {amount}.");
        }
    }
}
