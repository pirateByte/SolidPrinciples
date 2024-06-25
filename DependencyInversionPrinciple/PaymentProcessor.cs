using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class PaymentProcessor
    {
        private CreditCardPaymentService _creditCardPaymentService;
        private UPIPaymentService _upiPaymentService;

        public PaymentProcessor()
        {
            _creditCardPaymentService = new CreditCardPaymentService();
            _upiPaymentService = new UPIPaymentService();
        }

        public void ProcessPayment(Payment payment)
        {
            if (payment.PaymentMethod == "CreditCard")
            {
                _creditCardPaymentService.ProcessPayment(payment.Amount);
            }
            else if (payment.PaymentMethod == "UPI")
            {
                _upiPaymentService.ProcessPayment(payment.Amount);
            }
        }
    }
}
