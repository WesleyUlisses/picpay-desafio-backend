using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Services
{
    public interface IUserService
    {
        // vamos inserir as enterprises business logic aqui para User
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> Delete(User user);        

    }
}
