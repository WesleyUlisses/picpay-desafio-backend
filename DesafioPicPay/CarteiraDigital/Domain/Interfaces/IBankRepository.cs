using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface IBankRepository
    {
        Task<Bank> GetByBankCode(Guid bankCode);
        Task<Bank> Create(Bank bank);
        Task<Bank> Update(Bank bank);
        Task<Bank> Delete(Guid id);
    }
}
