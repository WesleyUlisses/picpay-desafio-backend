using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface IBusinessUserRepository
    {
        Task<BusinessUser> GetByUserId(Guid userId);
        Task<BusinessUser> Create(BusinessUser businessUser);
        Task<BusinessUser> Update(BusinessUser businessUser);
        Task<BusinessUser> Delete(Guid id);
    }
}
