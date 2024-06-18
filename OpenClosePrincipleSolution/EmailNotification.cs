using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipleSolution
{
    internal class EmailNotification : INotificationType
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }
}
