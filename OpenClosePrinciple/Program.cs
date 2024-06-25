namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new Notification();
            notification.Send("Welcome to VeArc", "SMS");
        }
    }
}
