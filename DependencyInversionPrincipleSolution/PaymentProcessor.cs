using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleSolution
{
    internal class PaymentProcessor
    {
        private readonly IPaymentService _paymentService;

        public PaymentProcessor(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessPayment(Payment payment)
        {
            _paymentService.ProcessPayment(payment.Amount);
        }
    }
}
