using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface ITransactionRepository
    {
        Task<Transaction> GetByTransactionId(Guid transactionId);
        Task<Transaction[]> GetAllByAccountNumber(Guid accountNumber);
        Task<Transaction> Create(Transaction transaction);
        Task<Transaction> Update(Transaction transaction);
        Task<Transaction> Delete(Guid id);
    }
}
