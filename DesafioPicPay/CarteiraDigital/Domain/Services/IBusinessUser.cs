using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Services
{
    public interface IBusinessUser : IUserService
    {
        Task<BusinessUser> Create(BusinessUser businessUser);
        Task<BusinessUser> Update(BusinessUser businessUser);
        Task<BusinessUser> Delete(BusinessUser businessUser);
    }
}
