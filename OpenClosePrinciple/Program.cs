namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotification notification = new INotification();
            notification.Send("Welcome to VeArc", "SMS");
        }
    }
}
