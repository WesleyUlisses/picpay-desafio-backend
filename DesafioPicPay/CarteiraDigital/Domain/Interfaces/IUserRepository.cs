using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByEmail(string email);
        Task<User> GetById(Guid id);
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> Delete(Guid id);

    }
}
