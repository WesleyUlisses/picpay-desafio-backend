using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface INotificationRepository
    {
        Task<Notification[]> GetAllByAccountNumber(Guid accountNumber);
        Task<Notification> Create(Notification notification);
        Task<Notification> Update(Notification notification);
        Task<Notification> Delete(Guid id);
    }
}
