using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefracesAbstractions.Task1
{
    public interface INotificationService
    {
        void Send(string message);
        string ServiceName { get; }
    }
}
