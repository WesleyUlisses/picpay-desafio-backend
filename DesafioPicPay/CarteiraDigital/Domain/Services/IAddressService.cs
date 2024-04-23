using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Services
{
    public interface IAddressService
    {
        Task<Address> Create(Address address);
        Task<Address> Update(Address address);
        Task<Address> Delete(Address address);
    }
}
