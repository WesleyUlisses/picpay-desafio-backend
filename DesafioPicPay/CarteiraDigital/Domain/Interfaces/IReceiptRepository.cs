using CarteiraDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Domain.Interfaces
{
    public interface IReceiptRepository
    {
        Task<Receipt[]> GetAllByAccountNumber(Guid accountNumber);
        Task<Receipt> Create(Receipt receipt);
        Task<Receipt> Update(Receipt receipt);
        Task<Receipt> Delete(Guid id);
    }
}
