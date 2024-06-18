using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipleSolution
{
    internal class Notification
    {
         private readonly INotificationType _notificationType;

    public Notification(INotificationType notificationType)
    {
        _notificationType = notificationType;
    }

    public void Send(string message)
    {
        _notificationType.Send(message);
    }
    }
}
