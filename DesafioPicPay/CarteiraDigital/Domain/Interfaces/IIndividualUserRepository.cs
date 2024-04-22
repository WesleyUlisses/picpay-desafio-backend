using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface IIndividualUserRepository
    {
        Task<IndividualUser> GetByUserId(Guid userId);
        Task<IndividualUser> Create(IndividualUser individualUser);
        Task<IndividualUser> Update(IndividualUser individualUser);
        Task<IndividualUser> Delete(Guid id);
    }
}
