namespace DependencyInversionPrincipleSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment UPIPayment = new Payment
            {
                Amount = 1,
                PaymentMethod = "UPI"
            };

            Payment CreditCardPayment = new Payment
            {
                Amount = 2,
                PaymentMethod = "CreditCard"
            };

            PaymentProcessor UPIPaymentProcessor = new PaymentProcessor(new UPIPaymentService());
            UPIPaymentProcessor.ProcessPayment(UPIPayment);

            PaymentProcessor CreditCardPaymentProcessor = new PaymentProcessor(new CreditCardPaymentService());
            CreditCardPaymentProcessor.ProcessPayment(CreditCardPayment);
        }
    }
}
