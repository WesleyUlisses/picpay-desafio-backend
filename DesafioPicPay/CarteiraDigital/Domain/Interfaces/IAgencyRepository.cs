using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface IAgencyRepository
    {
        Task<Agency> GetByAgencyID(Guid agencyId);
        Task<Agency[]> GetAllByBankCode(Guid bankCode);
        Task<Agency> Create(Agency agency);
        Task<Agency> Update(Agency agency);
        Task<Agency> Delete(Guid id);
    }
}
