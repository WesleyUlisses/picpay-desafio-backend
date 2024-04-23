using CarteiraDigital.Domain.Entities;
namespace CarteiraDigital.Domain.Services
{
    public interface INotificationService
    {
        Task<Notification> Create(Notification notification);
        Task<Notification> Update(Notification notification);
        Task<Notification> Delete(Notification notification);
        Task<Notification[]> GetAllByAccountNumber(Guid accountNumber);
        Task<Notification> SendNotification(Notification notification);
    }
}
