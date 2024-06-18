namespace OpenClosePrincipleSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new Notification(new SMSNotification());
            notification.Send("Welcome to VeArc");
        }
    }
}
