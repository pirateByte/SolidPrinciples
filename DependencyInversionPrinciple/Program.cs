namespace DependencyInversionPrinciple
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

            PaymentProcessor paymentProcessor = new PaymentProcessor();
            paymentProcessor.ProcessPayment(UPIPayment);
            paymentProcessor.ProcessPayment(CreditCardPayment);
        }
    }
}
