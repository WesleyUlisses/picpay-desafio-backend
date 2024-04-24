using CarteiraDigital.Domain.Entities;
using CarteiraDigital.Domain.Interfaces;

namespace CarteiraDigital.Application.UseCases.Transfer.Repository
{
    public interface ITransferRepository : ITransactionRepository
    {
        Task<Account> RecieveTransfer(Guid accountNumber, decimal value);
        Task<Account> SendTransfer(Guid accountNumber, decimal value);
        Task<Account> GetAllTransfer(Guid accountNumber);
        Task<Account> GetAllTransferByPeriod(Guid accountNumber, DateTime startDate, DateTime endDate);
        Task<Transaction> GetByTransactionId(Guid transactionId);
        Task<Transaction[]> GetAllByAccountNumber(Guid accountNumber);
        Task<Transaction> Create(Transaction transaction);
        Task<Transaction> Update(Transaction transaction);
        Task<Transaction> Delete(Guid id);

    }
}
