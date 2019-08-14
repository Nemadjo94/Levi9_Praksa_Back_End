using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
