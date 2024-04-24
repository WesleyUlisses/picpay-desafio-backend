using CarteiraDigital.Domain.Entities;
using CarteiraDigital.Domain.Services;
using CarteiraDigital.Application.UseCases.Transfer.Repository;

namespace CarteiraDigital.Application.UseCases.Transfer.Interfaces
{
    public interface ITransferService
    {
        Task<Account> RecieveTransfer(Guid accountNumber, decimal value);
        Task<Account> SendTransfer(Guid accountNumber, decimal value);
        Task<Account> GetAllTransfer(Guid accountNumber);
        Task<Account> GetAllTransferByPeriod(Guid accountNumber, DateTime startDate, DateTime endDate);
        
    }
}
