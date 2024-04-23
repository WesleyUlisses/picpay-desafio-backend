using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Services
{
    public interface IAgencyService
    {
        Task<Agency> Create(Agency agency);
        Task<Agency> Update(Agency agency);
        Task<Agency> Delete(Agency agency);
        Task<Agency> GetByAgencyNumber(Guid agencyNumber);
        Task<Agency> GetByAgencyName(string agencyName);
        Task<Agency> GetByAgencyCode(string agencyCode);
        Task<Agency[]> GetAllByBankNumber(Guid bankNumber);
        Task<Account> CreateAccount(Account account);
        Task<Account> UpdateAccount(Account account);
        Task<Account> DeleteAccount(Account account);
        Task<int> GetTotalOfAccountNumbers(Guid agencyNumber);
    }
}
