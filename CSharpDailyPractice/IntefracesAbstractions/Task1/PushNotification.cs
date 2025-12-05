using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IntefracesAbstractions.Task1
{
    public class PushNotification : INotificationService
    {
        public string ServiceName => "Push";

        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
