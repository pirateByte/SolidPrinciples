using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal class Notification
    {
        public void Send(string message, string notificationType)
        {
            // breaks open-close principle
            if (notificationType == "Email")
            {
                SendEmail(message);
            }
            else if (notificationType == "SMS")
            {
                SendSMS(message);
            }
            else if (notificationType == "Push")
            {
                SendPush(message);
            }
        }

        private void SendEmail(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }

        private void SendSMS(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }

        private void SendPush(string message)
        {
            Console.WriteLine("Sending Push Notification: " + message);
        }
    }
}
