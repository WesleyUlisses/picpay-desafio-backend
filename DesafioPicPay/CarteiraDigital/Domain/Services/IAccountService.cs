using CarteiraDigital.Domain.Entities;


namespace CarteiraDigital.Domain.Services
{
    public interface IAccountService
    {
        Task<Account> GetByUserId(Guid userId);
        Task<Account> GetByAccountNumber(Guid accountNumber);
        Task<Account> Create(Account account);
        Task<Account> Update(Account account);
        Task<Account> Delete(Guid id);
        Task<Account> Deposit(Guid accountNumber, decimal value);
        Task<Account> Withdraw(Guid accountNumber, decimal value);
        Task<Account> Transfer(Guid accountNumberOrigin, Guid accountNumberDestination, decimal value);
        Task<Account> GetBalance(Guid accountNumber);
        Task<Account> RecieveTransfer(Guid accountNumber, decimal value);
        Task<Account> SendTransfer(Guid accountNumber, decimal value);
        Task<Account> GetAllTransfer(Guid accountNumber);
        Task<Account> GetAllTransferByPeriod(Guid accountNumber, DateTime startDate, DateTime endDate);
    }
}
