using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface IAddressRepository
    {
        Task<Address> GetByUserId(Guid userId);
        Task<Address> Create(Address address);
        Task<Address> Update(Address address);
        Task<Address> Delete(Guid id);
    }
}
