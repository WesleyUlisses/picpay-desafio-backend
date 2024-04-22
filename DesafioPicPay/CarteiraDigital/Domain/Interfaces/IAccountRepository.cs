using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account> GetByUserId(Guid userId);
        Task<Account> GetByAccountNumber(Guid accountNumber);
        Task<Account> Create(Account account);
        Task<Account> Update(Account account);
        Task<Account> Delete(Guid id);
    }
}
