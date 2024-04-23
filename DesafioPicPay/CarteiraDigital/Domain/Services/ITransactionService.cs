using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Services
{
    public interface ITransactionService
    {
        Task<Transaction> Create(Transaction transaction);
        Task<Transaction> Update(Transaction transaction);
        Task<Transaction> Delete(Transaction transaction);
        Task<Transaction> GetByTransactionNumber(Guid transactionNumber);
        Task<Transaction[]> GetAllByAccountNumber(Guid accountNumber);
        Task<Transaction> Deposit(Guid accountNumber, decimal value, string type = "Deposit", Date date, string titularCPF, string titularName, string titularBankName);
        Task<Transaction> Withdraw(Guid accountNumber, decimal value, string type = "Withdraw", Date date, string titularCPF, string titularName, string titularBankName);
        Task<Transaction> Transfer(Guid accountNumberOrigin, Guid accountNumberDestination, decimal value, string recipientIdentificationNumber, string titularIdentificationNumber, string type = "Transfer", string titularName, string titularBankName, string recipientName, string recipientBankName, Date date);
    }
}
