using CarteiraDigital.Application.UseCases.Transfer.Interfaces;
using CarteiraDigital.Application.UseCases.Transfer.Repository;
using CarteiraDigital.Domain.Services;
using CarteiraDigital.Domain.Entities;


namespace CarteiraDigital.Application.UseCases.Transfer.Services
{
    public class TransferService : ITransferService
    {
        private ITransferRepository _transferRepository;
        private IAccountService _accountService;

        public TransferService(ITransferRepository transferRepository, IAccountService accountService)
        {
            _transferRepository = transferRepository;
            _accountService = accountService;
        }

        public async Task<Account> Transfer(Guid accountNumberOrigin, Guid accountNumberDestination, decimal value, string userOriginType = "IndividualUser")
        {

            if(accountNumberOrigin == Guid.Empty)
            {
                throw new Exception("Invalid Origin Account Number");
            }

            if(this.GetBalance(accountNumberOrigin).Result.Balance < value)
            {
                throw new Exception("Insufficient Balance");
            }

            if(accountNumberDestination == accountNumberOrigin)
            {
                throw new Exception("You cannot transfer to the same account");
            }

            if(accountNumberDestination == Guid.Empty)
            {
                throw new Exception("Invalid Destination Account Number");
            }

            if(value <= 0)
            {
                throw new Exception("Invalid Value");
            }

            if(userOriginType != "IndividualUser")
            {
                throw new Exception("Only Individual Users Can Transfer");
            }
            
            return await _accountService.Transfer(accountNumberOrigin, accountNumberDestination, value);
            
        }

        public async Task<Account> GetAllTransfer(Guid accountNumber)
        {
            return await _accountService.GetAllTransfer(accountNumber);
        }

        public async Task<Account> GetAllTransferByPeriod(Guid accountNumber, DateTime startDate, DateTime endDate)
        {
            return await _accountService.GetAllTransferByPeriod(accountNumber, startDate, endDate);
        }

        public Task<Account> RecieveTransfer(Guid accountNumber, decimal value)
        {
            throw new NotImplementedException();
        }

        public Task<Account> SendTransfer(Guid accountNumber, decimal value)
        {
            throw new NotImplementedException();
        }

        private async Task<Account> GetBalance(Guid accountNumber)
        {
            return await _accountService.GetBalance(accountNumber);
        }
    }

}
