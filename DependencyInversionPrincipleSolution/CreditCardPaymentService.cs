﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleSolution
{
    internal class CreditCardPaymentService : IPaymentService
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}.");
        }
    }
}
