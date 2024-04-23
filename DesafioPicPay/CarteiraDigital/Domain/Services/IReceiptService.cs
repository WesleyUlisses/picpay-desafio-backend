using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Services
{
    public interface IReceiptService
    {
        Task<Receipt> Create(Receipt receipt);
        Task<Receipt> Update(Receipt receipt);
        Task<Receipt> Delete(Receipt receipt);
        Task<Receipt[]> GetByAccountNumber(Guid accountNumber);
        Task<Receipt[]> GetByAccountNumberOnPeriod(Guid accountNumber, DateTime startDate, DateTime endDate);
        Task<Receipt> GenerateReceipt(Transaction transaction);

    }
}
