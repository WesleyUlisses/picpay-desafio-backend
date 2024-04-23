using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Services
{
    public interface IIndividualUserService: IUserService
    {
        Task<IndividualUser> Create(IndividualUser individualUser);
        Task<IndividualUser> Update(IndividualUser individualUser);
        Task<IndividualUser> Delete(IndividualUser individualUser);

    }
}
