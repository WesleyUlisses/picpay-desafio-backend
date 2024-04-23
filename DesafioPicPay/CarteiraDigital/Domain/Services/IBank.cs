using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Services
{
    public interface IBank
    {
        Task<Bank> Create(Bank bank);
        Task<Bank> Update(Bank bank);
        Task<Bank> Delete(Bank bank);
        Task<Bank> GetByBankNumber(Guid bankNumber);
        Task<Bank> GetByBankName(string bankName);
        Task<Bank> GetByBankCode(string bankCode);

    }
}
